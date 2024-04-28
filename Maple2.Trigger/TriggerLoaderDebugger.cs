using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;

namespace Maple2.Trigger;

// This class should only be used to debug the trigger ingame
// It'll return all State Triggers instead of only the initial state
public class TriggerLoaderDebugger
{
    private readonly Dictionary<string, Dictionary<string, List<Func<ITriggerContext, TriggerState>>>> scriptLookup;

    public TriggerLoaderDebugger()
    {
        scriptLookup = new Dictionary<string, Dictionary<string, List<Func<ITriggerContext, TriggerState>>>>();

        var assembly = Assembly.GetAssembly(typeof(TriggerLoader));
        foreach (Type type in assembly.GetTypes())
        {
            if (!type.IsNested) continue;

            ConstructorInfo? constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new[] { typeof(ITriggerContext) }, null);


            // No matching constructor for dungeon_common
            if (constructor == null || type.Namespace == null || type.DeclaringType == null)
            {
                continue;
            }

            string key = GetKey(type.Namespace);

            if (!scriptLookup.ContainsKey(key))
            {
                scriptLookup[key] = new Dictionary<string, List<Func<ITriggerContext, TriggerState>>>();

                string declaryingTypeName = GetKey(type.DeclaringType.Name);
                var newList = new List<Func<ITriggerContext, TriggerState>> { context => (TriggerState)constructor.Invoke(new object[] { context }) };
                scriptLookup[key].Add(declaryingTypeName, newList);
                continue;
            }

            var existing = scriptLookup[key];
            if (existing.TryGetValue(GetKey(type.DeclaringType.Name), out List<Func<ITriggerContext, TriggerState>>? value))
            {
                value?.Add(context => (TriggerState)constructor.Invoke(new object[] { context }));
                continue;
            }
        }
    }

    public bool TryGetTrigger(string mapName, string scriptName, [NotNullWhen(true)] out List<Func<ITriggerContext, TriggerState>?> func)
    {
        if (!scriptLookup.ContainsKey(mapName))
        {
            func = null;
            return false;
        }

        return scriptLookup[mapName].TryGetValue(scriptName, out func);
    }

    public IReadOnlyDictionary<string, List<Func<ITriggerContext, TriggerState>>> GetTriggerTable(string mapName)
    {
        if (!scriptLookup.ContainsKey(mapName))
        {
            return new Dictionary<string, List<Func<ITriggerContext, TriggerState>>>();
        }

        return scriptLookup[mapName];
    }

    public List<Func<ITriggerContext, TriggerState>>[] GetTriggers(string mapName)
    {
        if (!scriptLookup.ContainsKey(mapName))
        {
            return Array.Empty<List<Func<ITriggerContext, TriggerState>>>();
        }

        return scriptLookup[mapName].Values.ToArray();
    }

    private static string GetKey(string @namespace)
    {
        int start = @namespace.IndexOf('_');
        Debug.Assert(start != -1);
        return @namespace.Substring(start + 1);
    }
}
