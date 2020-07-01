namespace Maple2.Trigger._66200001_gd {
    public static class _sensor_9320 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box32Check", value: 10);
                context.SetMesh(arg1: new[] {532}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {5320}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Box32Check") == 0) {
                    context.State = new StateSensor0(context);
                    return;
                }

                if (context.GetUserValue(key: "Box32Check") == 1) {
                    context.State = new StateSensor1(context);
                    return;
                }

                if (context.GetUserValue(key: "Box32Check") == 2) {
                    context.State = new StateSensor2(context);
                    return;
                }

                if (context.GetUserValue(key: "Box32Check") == 3) {
                    context.State = new StateSensor3(context);
                    return;
                }

                if (context.GetUserValue(key: "Box32Check") == 4) {
                    context.State = new StateSensor4(context);
                    return;
                }

                if (context.GetUserValue(key: "Box32Check") == 5) {
                    context.State = new StateSensor5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor0 : TriggerState {
            internal StateSensor0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor1 : TriggerState {
            internal StateSensor1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 1) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 1) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor2 : TriggerState {
            internal StateSensor2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 2) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 2) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor3 : TriggerState {
            internal StateSensor3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 3) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 3) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor4 : TriggerState {
            internal StateSensor4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 4) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 4) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor5 : TriggerState {
            internal StateSensor5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9320) == 5) {
                    context.State = new StateNormalPass(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9320) != 5) {
                    context.State = new StateFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNormalPass : TriggerState {
            internal StateNormalPass(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Pass_01");
                context.SetUserValue(triggerId: 7320, key: "ColorReset", value: 1);
                context.SetMesh(arg1: new[] {532}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9320}, arg2: "DDStop_Stage_Fail_01");
                context.SetMesh(arg1: new[] {532}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new[] {5320}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 7320, key: "ColorClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Box32Check", value: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}