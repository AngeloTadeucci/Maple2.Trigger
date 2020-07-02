namespace Maple2.Trigger._02000047_bf {
    public static class _03_rarebox_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {305}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new StateSetup05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05 : TriggerState {
            internal StateSetup05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {305}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {105})) {
                    return new StateSetup05끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05끝 : TriggerState {
            internal StateSetup05끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "405", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "405")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}