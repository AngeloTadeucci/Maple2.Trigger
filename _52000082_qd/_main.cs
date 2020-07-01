namespace Maple2.Trigger._52000082_qd {
    public static class _main {
        public class Statemapskill : TriggerState {
            internal Statemapskill(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new Statemapskill_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statemapskill_start : TriggerState {
            internal Statemapskill_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 70000114, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statemapskill(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}