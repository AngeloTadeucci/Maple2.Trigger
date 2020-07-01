namespace Maple2.Trigger._52000027_qd {
    public static class _randomlever02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1번패턴(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2번패턴(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State3번패턴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴 : TriggerState {
            internal State1번패턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    context.State = new State1번패턴_모든레버켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_모든레버켜기 : TriggerState {
            internal State1번패턴_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State1번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State1번패턴_2번레버_오답01(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State1번패턴_3번레버_오답01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_정답 : TriggerState {
            internal State1번패턴_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_2번레버_오답01 : TriggerState {
            internal State1번패턴_2번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State1번패턴_2번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_2번레버_재도전 : TriggerState {
            internal State1번패턴_2번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State1번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State1번패턴_2번레버_오답02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_2번레버_오답02 : TriggerState {
            internal State1번패턴_2번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State1번패턴_2번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_2번레버_마지막도전 : TriggerState {
            internal State1번패턴_2번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State1번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_3번레버_오답01 : TriggerState {
            internal State1번패턴_3번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State1번패턴_3번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_3번레버_재도전 : TriggerState {
            internal State1번패턴_3번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State1번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State1번패턴_3번레버_오답02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_3번레버_오답02 : TriggerState {
            internal State1번패턴_3번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State1번패턴_3번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번패턴_3번레버_마지막도전 : TriggerState {
            internal State1번패턴_3번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State1번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴 : TriggerState {
            internal State2번패턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    context.State = new State2번패턴_모든레버켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_모든레버켜기 : TriggerState {
            internal State2번패턴_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State2번패턴_1번레버_오답01(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State2번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State2번패턴_3번레버_오답01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_정답 : TriggerState {
            internal State2번패턴_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_1번레버_오답01 : TriggerState {
            internal State2번패턴_1번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State2번패턴_1번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_1번레버_재도전 : TriggerState {
            internal State2번패턴_1번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State2번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State2번패턴_1번레버_오답02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_1번레버_오답02 : TriggerState {
            internal State2번패턴_1번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State2번패턴_1번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_1번레버_마지막도전 : TriggerState {
            internal State2번패턴_1번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State2번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_3번레버_오답01 : TriggerState {
            internal State2번패턴_3번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State2번패턴_3번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_3번레버_재도전 : TriggerState {
            internal State2번패턴_3번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State2번패턴_정답(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State2번패턴_3번레버_오답02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_3번레버_오답02 : TriggerState {
            internal State2번패턴_3번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State2번패턴_3번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번패턴_3번레버_마지막도전 : TriggerState {
            internal State2번패턴_3번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State2번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴 : TriggerState {
            internal State3번패턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SetLever") == 1) {
                    context.State = new State3번패턴_모든레버켜기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_모든레버켜기 : TriggerState {
            internal State3번패턴_모든레버켜기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State3번패턴_1번레버_오답01(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State3번패턴_2번레버_오답01(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State3번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_정답 : TriggerState {
            internal State3번패턴_정답(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetUserValue(triggerId: 1, key: "TrapOpen", value: 1);
                context.SetUserValue(triggerId: 3, key: "TrapOpen", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_1번레버_오답01 : TriggerState {
            internal State3번패턴_1번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State3번패턴_1번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_1번레버_재도전 : TriggerState {
            internal State3번패턴_1번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000476}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000476}, arg2: 0)) {
                    context.State = new State3번패턴_1번레버_오답02(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State3번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_1번레버_오답02 : TriggerState {
            internal State3번패턴_1번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State3번패턴_1번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_1번레버_마지막도전 : TriggerState {
            internal State3번패턴_1번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State3번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_2번레버_오답01 : TriggerState {
            internal State3번패턴_2번레버_오답01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__0$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {921}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State3번패턴_2번레버_재도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_2번레버_재도전 : TriggerState {
            internal State3번패턴_2번레버_재도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000475}, arg2: 1);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000475}, arg2: 0)) {
                    context.State = new State3번패턴_2번레버_오답02(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State3번패턴_정답(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_2번레버_오답02 : TriggerState {
            internal State3번패턴_2번레버_오답02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000027_QD__RANDOMLEVER02__1$", arg4: 3, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 0);
                context.CreateMonster(arg1: new[] {922}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {921})) {
                    context.State = new State3번패턴_2번레버_마지막도전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번패턴_2번레버_마지막도전 : TriggerState {
            internal State3번패턴_2번레버_마지막도전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000477}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000477}, arg2: 0)) {
                    context.State = new State3번패턴_정답(context);
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