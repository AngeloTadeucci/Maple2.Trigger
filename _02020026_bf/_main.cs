namespace Maple2.Trigger._02020026_bf {
    public static class _main {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__0$",
                    duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__1$",
                    duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24110001, illustId: "Neirin_normal", msg: "$02020026_BF__main__2$",
                    duration: 5000, align: "left");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}