namespace Maple2.Trigger._02020027_bf {
    public static class _battle_4 {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State전투시작_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작_2 : TriggerState {
            internal State전투시작_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "summon_2_2") == 1) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401, 402, 403, 404, 405, 406});
                context.SetConversation(arg1: 1, arg2: 401, arg3: "$02020027_BF__battle_1__1$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 403, arg3: "$02020027_BF__battle_1__2$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 405, arg3: "$02020027_BF__battle_1__3$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {401, 402, 403, 404, 405, 406})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {201}, arg2: 62000002, arg3: 1, arg4: true);
                context.AddBuff(arg1: new[] {201}, arg2: 51200002, arg3: 1, arg4: true);
            }

            public override void Execute() {
                if (true) { }
            }

            public override void OnExit() { }
        }
    }
}