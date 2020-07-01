namespace Maple2.Trigger._52100053_qd {
    public static class _06_gratingdown {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002104, 10002105}, arg2: 0);
                context.SetMesh(arg1: new[] {6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {6300, 6301, 6302, 6303, 6304, 6305}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3901}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
                context.SetBreakable(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002}, arg2: false);
                context.SetUserValue(key: "BlockEnable", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "BlockEnable") == 1) {
                    context.State = new StateBlockEnable(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockEnable : TriggerState {
            internal StateBlockEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002104}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002104}, arg2: 0)) {
                    context.State = new StateBlockStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockStart : TriggerState {
            internal StateBlockStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6300, 6301, 6302, 6303, 6304, 6305}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlockIng(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockIng : TriggerState {
            internal StateBlockIng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3901}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {8000, 8001, 8002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBlockEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockEnd : TriggerState {
            internal StateBlockEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6000, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBlockDisable(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockDisable : TriggerState {
            internal StateBlockDisable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002105}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002105}, arg2: 0)) {
                    context.State = new StateBlockOffStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockOffStart : TriggerState {
            internal StateBlockOffStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6200, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211}, arg2: false, arg3: 100, arg4: 0, arg5: 2f);
                context.SetBreakable(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlockOffIng(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockOffIng : TriggerState {
            internal StateBlockOffIng(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3901}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetAgent(arg1: new[] {8000, 8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateBlockOffEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlockOffEnd : TriggerState {
            internal StateBlockOffEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6300, 6301, 6302, 6303, 6304, 6305}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetBreakable(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBlockEnable(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}