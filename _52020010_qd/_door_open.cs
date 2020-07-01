namespace Maple2.Trigger._52020010_qd {
    public static class _door_open {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5016, 5017}, arg2: false);
                context.SetBreakable(arg1: new[] {10001, 10002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2005}, arg2: new[] {60200050}, arg3: new byte[] {2})) {
                    context.State = new StateCheck(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2005}, arg2: new[] {60200050}, arg3: new byte[] {3})) {
                    context.State = new StateCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheck : TriggerState {
            internal StateCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001275}, arg2: 0)) {
                    context.State = new StateDoorOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDoorOpen : TriggerState {
            internal StateDoorOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5016, 5017}, arg2: true);
                context.SetBreakable(arg1: new[] {10001, 10002}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}