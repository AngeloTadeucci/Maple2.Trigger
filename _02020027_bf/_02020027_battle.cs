namespace Maple2.Trigger._02020027_bf {
    public static class _02020027_battle {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Success", value: 0);
                context.SetUserValue(triggerId: 99990001, key: "End", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "battlesetting") == 1) {
                    context.State = new State전투_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_시작 : TriggerState {
            internal State전투_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonResetTime(seconds: 300);
                context.SetNpcDuelHpBar(isOpen: true, spawnPointId: 201, durationTick: 300000, npcHpStep: 100);
            }

            public override void Execute() {
                if (context.GetDungeonPlayTime() <= 180
                    && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24094005);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() <= 70
                    && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24094006);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() <= 270
                    && context.MonsterDead(arg1: new[] {201})) {
                    context.DungeonMissionComplete(missionId: 24094010);
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {201})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {1003})) {
                    context.State = new State전투_종료(context);
                    return;
                }

                if (context.GetDungeonPlayTime() == 300) {
                    context.State = new State전투_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투_종료 : TriggerState {
            internal State전투_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonSetEndTime();
                context.DestroyMonster(arg1: new[] {-1});
                context.SideNpcTalk(npcId: 24120006, illust: "Mason_normal", duration: 4000,
                    script: "$02020027_BF__02020027_battle__0$", voice: @"ko/Npc/00002259");
                context.SetNpcDuelHpBar(isOpen: false, spawnPointId: 201);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료신호(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료신호 : TriggerState {
            internal State종료신호(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "End", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}