namespace Maple2.Trigger._02000066_bf {
    public static class _cannon_effect12 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{812}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{122})) {
                    return new State이펙트Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트Wait : TriggerState {
            internal State이펙트Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 122, spawnIds: new []{8012})) {
                    return new State이펙트on(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이펙트on : TriggerState {
            internal State이펙트on(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{812}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{8012})) {
                    return new StateWaitTime(context);
                }

                if (!context.UserDetected(boxIds: new []{122})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{812}, visible: false);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}