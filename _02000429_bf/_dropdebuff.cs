namespace Maple2.Trigger._02000429_bf {
    public static class _dropdebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    context.State = new State드랍어뷰징디버프_작동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State드랍어뷰징디버프_작동시작 : TriggerState {
            internal State드랍어뷰징디버프_작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 780) == 1) {
                    context.State = new State전투판에떨어지면디버프걸기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투판에떨어지면디버프걸기 : TriggerState {
            internal State전투판에떨어지면디버프걸기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {780}, arg2: 50000512, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State드랍어뷰징디버프_작동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}