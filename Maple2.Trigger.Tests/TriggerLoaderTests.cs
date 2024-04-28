using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maple2.Trigger.Tests;

[TestClass]
public class TriggerLoaderTests
{

    [TestMethod]
    public void TriggerLoaderDebuggerTest()
    {
        TriggerLoaderDebugger TriggerLoader = new();

        if (!TriggerLoader.TryGetTrigger("52000111_qd", "52000111", out List<Func<ITriggerContext, TriggerState>?> initialState))
        {
            Assert.Fail();
        }

        Assert.IsNotNull(initialState);
        Assert.IsTrue(initialState.Count == 34);
    }

    [TestMethod]
    public void TriggerLoaderTest()
    {
        TriggerLoader TriggerLoader = new();

        if (!TriggerLoader.TryGetTrigger("52000111_qd", "52000111", out Func<ITriggerContext, TriggerState>? initialState))
        {
            Assert.Fail();
        }

        Assert.IsNotNull(initialState);        
    }
}