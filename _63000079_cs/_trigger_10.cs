namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_10 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    context.State = new State발판10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판10 : TriggerState {
            internal State발판10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {110})) {
                    context.State = new State발판10끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판10끝 : TriggerState {
            internal State발판10끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "410", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "410")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}