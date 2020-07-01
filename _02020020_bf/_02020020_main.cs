namespace Maple2.Trigger._02020020_bf {
    public static class _02020020_main {
        public class State카메라_네이린설명1 : TriggerState {
            internal State카메라_네이린설명1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020020_BF__02020020_main__0$", duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020020_BF__02020020_main__1$", duration: 5000, align: "left");
                context.AddCinematicTalk(npcId: 24100001, illustId: "Neirin_normal", msg: "$02020020_BF__02020020_main__2$", duration: 5000, align: "left");
            }

            public override void Execute() { }

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