namespace Maple2.Trigger._52100053_qd {
    public static class _01_searchhiddenroute {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: false);
                context.SetUserValue(key: "PortalOn", value: 0);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePickRandomRoute(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePickRandomRoute : TriggerState {
            internal StatePickRandomRoute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039701, textId: 20039701, duration: 4000);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateBehindFireplace(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateBehindBookcase(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateFindKeyFromFabricbox(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateFindKeyFromCandle(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new StateFindKeyFromDocument(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBehindBookcase : TriggerState {
            internal StateBehindBookcase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateBehindFireplace : TriggerState {
            internal StateBehindFireplace(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateFindKeyFromFabricbox : TriggerState {
            internal StateFindKeyFromFabricbox(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 1);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    context.State = new StatePortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindKeyFromCandle : TriggerState {
            internal StateFindKeyFromCandle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 1);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    context.State = new StatePortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFindKeyFromDocument : TriggerState {
            internal StateFindKeyFromDocument(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    context.State = new StatePortalOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}