namespace Maple2.Trigger._61000004_me {
    public static class _goal {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "gameStart") == 1) {
                    context.State = new State결승점(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결승점 : TriggerState {
            internal State결승점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 102, isOnlyWinner: true, expRate: 1.0f);
                context.MiniGameGiveReward(winnerBoxId: 102, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 102, isOnlyWinner: true, gameName: "escape");
                context.AddBuff(arg1: new[] {102}, arg2: 70000019, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State결승점(context);
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