namespace Maple2.Trigger._02020061_bf {
    public static class _object4 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 0);
                context.SetInteractObject(arg1: new[] {12000087}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 1) {
                    context.State = new State레버4_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_체크 : TriggerState {
            internal State레버4_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {724}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {714})) {
                    context.State = new State레버4_발동(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9014})) {
                    context.State = new State레버4_안내멘트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_안내멘트 : TriggerState {
            internal State레버4_안내멘트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__OBJECT4__0$", arg3: 5000, arg4: "9014");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {714})) {
                    context.State = new State레버4_발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_발동 : TriggerState {
            internal State레버4_발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000087}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__OBJECT4__1$", arg3: 5000, arg4: "9014");
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000087}, arg2: 0)) {
                    context.State = new State레버4_몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_몬스터등장 : TriggerState {
            internal State레버4_몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State레버4_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_재활성 : TriggerState {
            internal State레버4_재활성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000087}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000087}, arg2: 0)) {
                    context.State = new State레버4_재활성_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레버4_재활성_대기 : TriggerState {
            internal State레버4_재활성_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "ObjectStart") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {701})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State레버4_재활성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5301}, arg2: false);
                context.SetUserValue(triggerId: 99990014, key: "EliteSpawn", value: 2);
                context.DestroyMonster(arg1: new[] {724}, arg2: false);
                context.SetInteractObject(arg1: new[] {12000087}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}