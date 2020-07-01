namespace Maple2.Trigger._99999841 {
    public static class _pc_move {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State애디셔널체크 : TriggerState {
            internal State애디셔널체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 9001, additionalEffectId: 70002541, level: true)
                ) {
                    context.State = new State유저이동확률(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동확률 : TriggerState {
            internal State유저이동확률(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State유저이동1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 34f)) {
                    context.State = new State유저이동2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 33f)) {
                    context.State = new State유저이동3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동1 : TriggerState {
            internal State유저이동1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999840, arg2: 2, arg3: 9102);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동2 : TriggerState {
            internal State유저이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999840, arg2: 3, arg3: 9102);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동3 : TriggerState {
            internal State유저이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 99999840, arg2: 4, arg3: 9102);
            }

            public override void Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기(context);
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