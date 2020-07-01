namespace Maple2.Trigger._02000066_bf {
    public static class _triny {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "randomTalk") == 1) {
                    context.CreateMonster(arg1: new[] {5002}, arg2: false);
                    context.State = new State전투대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투대기 : TriggerState {
            internal State전투대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {5002})) {
                    context.State = new State말풍선랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State말풍선랜덤 : TriggerState {
            internal State말풍선랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new StateNPC대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사01 : TriggerState {
            internal StateNPC대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5002, arg3: "$02000066_BF__TRINY__0$", arg4: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사02 : TriggerState {
            internal StateNPC대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5002, arg3: "$02000066_BF__TRINY__1$", arg4: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사03 : TriggerState {
            internal StateNPC대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5002, arg3: "$02000066_BF__TRINY__2$", arg4: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사04 : TriggerState {
            internal StateNPC대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 5002, arg3: "$02000066_BF__TRINY__3$", arg4: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State전투대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}