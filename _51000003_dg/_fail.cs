namespace Maple2.Trigger._51000003_dg {
    public static class _fail {
        public class Stategameset : TriggerState {
            internal Stategameset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Fail") == 1) {
                    context.State = new StateFail_condition(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail_condition : TriggerState {
            internal StateFail_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 799) == 1) {
                    context.State = new StateFail(context);
                    return;
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    context.State = new StateFail(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {701})) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Ending_Popup_01");
                context.SetTimer(arg1: "10", arg2: 10, arg4: true);
                context.CameraSelectPath(arg1: new[] {8800}, arg2: false);
                context.ArcadeBoomBoomOcean(type: "EndGame");
                context.SetUserValue(triggerId: 991104, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991105, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991106, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991107, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991108, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991111, key: "Round_01", value: 0);
                context.SetUserValue(triggerId: 991120, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991121, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991122, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991123, key: "Reset", value: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0, arg3: 705);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}