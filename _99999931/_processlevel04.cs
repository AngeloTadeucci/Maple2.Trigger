namespace Maple2.Trigger._99999931 {
    public static class _processlevel04 {
        public class State레버당기기 : TriggerState {
            internal State레버당기기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000220}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000220}, arg2: 0)) {
                    context.State = new State카운트다운1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운1 : TriggerState {
            internal State카운트다운1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "31", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "3", arg3: 1000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "31")) {
                    context.State = new State카운트다운2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운2 : TriggerState {
            internal State카운트다운2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "32", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "2", arg3: 1000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "32")) {
                    context.State = new State카운트다운3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트다운3 : TriggerState {
            internal State카운트다운3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "1", arg3: 1000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State게임시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "34", arg2: 1);
                context.SetBreakable(
                    arg1: new[] {
                        101, 102, 104, 105, 107, 108, 111, 112, 114, 115, 117, 118, 120, 121, 122, 123, 125, 126, 128,
                        129, 130, 131, 132, 135, 136
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "34")) {
                    context.State = new State게임진행1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임진행1 : TriggerState {
            internal State게임진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 1);
                context.SetBreakable(
                    arg1: new[] {
                        101, 102, 104, 105, 107, 108, 111, 112, 114, 115, 117, 118, 120, 121, 122, 123, 125, 126, 128,
                        129, 130, 131, 132, 135, 136
                    }, arg2: false);
                context.SetSkill(arg1: new[] {801}, arg2: true);
                context.SetSkill(arg1: new[] {802}, arg2: true);
                context.SetSkill(arg1: new[] {804}, arg2: true);
                context.SetSkill(arg1: new[] {805}, arg2: true);
                context.SetSkill(arg1: new[] {807}, arg2: true);
                context.SetSkill(arg1: new[] {808}, arg2: true);
                context.SetSkill(arg1: new[] {811}, arg2: true);
                context.SetSkill(arg1: new[] {812}, arg2: true);
                context.SetSkill(arg1: new[] {814}, arg2: true);
                context.SetSkill(arg1: new[] {815}, arg2: true);
                context.SetSkill(arg1: new[] {817}, arg2: true);
                context.SetSkill(arg1: new[] {818}, arg2: true);
                context.SetSkill(arg1: new[] {820}, arg2: true);
                context.SetSkill(arg1: new[] {821}, arg2: true);
                context.SetSkill(arg1: new[] {822}, arg2: true);
                context.SetSkill(arg1: new[] {823}, arg2: true);
                context.SetSkill(arg1: new[] {825}, arg2: true);
                context.SetSkill(arg1: new[] {826}, arg2: true);
                context.SetSkill(arg1: new[] {828}, arg2: true);
                context.SetSkill(arg1: new[] {829}, arg2: true);
                context.SetSkill(arg1: new[] {830}, arg2: true);
                context.SetSkill(arg1: new[] {831}, arg2: true);
                context.SetSkill(arg1: new[] {832}, arg2: true);
                context.SetSkill(arg1: new[] {835}, arg2: true);
                context.SetSkill(arg1: new[] {836}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State게임진행2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임진행2 : TriggerState {
            internal State게임진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "36", arg2: 2);
                context.SetSkill(arg1: new[] {801}, arg2: false);
                context.SetSkill(arg1: new[] {802}, arg2: false);
                context.SetSkill(arg1: new[] {804}, arg2: false);
                context.SetSkill(arg1: new[] {805}, arg2: false);
                context.SetSkill(arg1: new[] {807}, arg2: false);
                context.SetSkill(arg1: new[] {808}, arg2: false);
                context.SetSkill(arg1: new[] {811}, arg2: false);
                context.SetSkill(arg1: new[] {812}, arg2: false);
                context.SetSkill(arg1: new[] {814}, arg2: false);
                context.SetSkill(arg1: new[] {815}, arg2: false);
                context.SetSkill(arg1: new[] {817}, arg2: false);
                context.SetSkill(arg1: new[] {818}, arg2: false);
                context.SetSkill(arg1: new[] {820}, arg2: false);
                context.SetSkill(arg1: new[] {821}, arg2: false);
                context.SetSkill(arg1: new[] {822}, arg2: false);
                context.SetSkill(arg1: new[] {823}, arg2: false);
                context.SetSkill(arg1: new[] {825}, arg2: false);
                context.SetSkill(arg1: new[] {826}, arg2: false);
                context.SetSkill(arg1: new[] {828}, arg2: false);
                context.SetSkill(arg1: new[] {829}, arg2: false);
                context.SetSkill(arg1: new[] {830}, arg2: false);
                context.SetSkill(arg1: new[] {831}, arg2: false);
                context.SetSkill(arg1: new[] {832}, arg2: false);
                context.SetSkill(arg1: new[] {835}, arg2: false);
                context.SetSkill(arg1: new[] {836}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "36")) {
                    context.State = new State레버당기기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}