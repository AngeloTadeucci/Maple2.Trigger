namespace Maple2.Trigger._02000066_bf {
    public static class _q10003067 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {103}, arg2: new[] {50001642}, arg3: new byte[] {2})) {
                    context.State = new State포털활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털활성화 : TriggerState {
            internal State포털활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "woodsoflife") == 1) {
                    // context.State = new State포털비활성화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State가이드활성화 : TriggerState {
            internal State가이드활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10003067);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}