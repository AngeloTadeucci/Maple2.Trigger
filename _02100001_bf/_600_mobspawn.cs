namespace Maple2.Trigger._02100001_bf {
    public static class _600_mobspawn {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RemoveAll", value: 0);
                context.DestroyMonster(arg1: new[] {600, 601, 602, 603, 604, 701, 702, 703, 704, 705});
            }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.State = new StateMobSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMobSpawn : TriggerState {
            internal StateMobSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {600, 601, 602, 603, 604, 701, 702, 703, 704, 705}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RemoveAll") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {600, 601, 602, 603, 604, 701, 702, 703, 704, 705});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}