namespace Maple2.Trigger._02000535_bf {
    public static class _main2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {707}, arg2: 0)) {
                    return new State데코지우고Monster스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State데코지우고Monster스폰 : TriggerState {
            internal State데코지우고Monster스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {5501, 5502, 5503, 5504, 5505, 5520, 5521, 5522, 5523, 5532});
                context.CreateMonster(arg1: new[] {501, 522, 532, 533, 534, 535, 536, 537, 538}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {501, 522, 532, 533, 534, 535, 536, 537, 538})) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {5501, 5502, 5503, 5504, 5505, 5520, 5521, 5522, 5523, 5532, 501, 522, 532, 533, 534, 535, 536, 537, 538});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}