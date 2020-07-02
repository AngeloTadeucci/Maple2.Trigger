namespace Maple2.Trigger._02020030_bf {
    public static class _11002_playd {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PlayD", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PlayD") == 1) {
                    return new StateActorOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActorOff : TriggerState {
            internal StateActorOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000059}, arg2: 0)) {
                    return new StateActorOn(context);
                }

                if (context.GetUserValue(key: "PlayD") == 0) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActorOn : TriggerState {
            internal StateActorOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_orange");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateResetDelay(context);
                }

                if (context.GetUserValue(key: "PlayD") == 0) {
                    return new StateResetDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11002, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateActorOff(context);
                }

                if (context.GetUserValue(key: "PlayD") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}