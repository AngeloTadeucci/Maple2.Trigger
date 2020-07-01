namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_07 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    context.State = new State발판07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판07 : TriggerState {
            internal State발판07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {107})) {
                    context.State = new State발판07끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판07끝 : TriggerState {
            internal State발판07끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "407", arg2: 2, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "407")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}