namespace Maple2.Trigger._02020063_bf {
    public static class _message {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020063_BF__MESSAGE__0$", arg3: 5000);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    context.State = new State체력공지_1(context);
                    return;
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    context.State = new State체력공지_1(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력공지_1 : TriggerState {
            internal State체력공지_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 801) <= 0.50f) {
                    context.SetEventUI(arg1: 1, arg2: "$02020063_BF__MESSAGE__1$", arg3: 5000);
                    context.State = new State체력공지_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력공지_2 : TriggerState {
            internal State체력공지_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 801) <= 0.30f) {
                    context.SetEventUI(arg1: 1, arg2: "$02020063_BF__MESSAGE__2$", arg3: 5000);
                    context.State = new State체력공지_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체력공지_3 : TriggerState {
            internal State체력공지_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 801) <= 0.10f) {
                    context.SetEventUI(arg1: 1, arg2: "$02020063_BF__MESSAGE__3$", arg3: 5000);
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