namespace Maple2.Trigger._02020311_bf {
    public static class _sidetalk {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Sidetalk") == 1) {
                    context.SideNpcTalk(type: "talk", npcId: 11004715, illust: "Eone_serious",
                        script: "$02020311_BF__SIdETALK__0$", duration: 3000);
                    context.State = new State세번째(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째 : TriggerState {
            internal State세번째(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Sidetalk") == 2) {
                    context.SideNpcTalk(type: "talk", npcId: 11004715, illust: "Eone_serious",
                        script: "$02020311_BF__SIdETALK__1$", duration: 3000);
                    context.State = new State네번째(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째 : TriggerState {
            internal State네번째(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Sidetalk") == 3) {
                    context.SideNpcTalk(type: "talk", npcId: 11004715, illust: "Eone_serious",
                        script: "$02020311_BF__SIdETALK__2$", duration: 3000);
                    context.State = new State대사대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사대기 : TriggerState {
            internal State대사대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State계속(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계속 : TriggerState {
            internal State계속(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004715, illust: "Eone_serious",
                        script: "$02020311_BF__SIdETALK__3$", duration: 3000);
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