namespace Maple2.Trigger._02000482_bf {
    public static class _12_ironplatetrap {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3430, 3431, 3432, 3433}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303}, arg2: false);
                context.DestroyMonster(arg1: new[] {203, 303});
                context.SetInteractObject(arg1: new[] {10002029}, arg2: 0, arg4: false);
                context.SetUserValue(key: "TrapOn", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "TrapOn") == 1) {
                    context.State = new StateLeverOnDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLeverOnDelay : TriggerState {
            internal StateLeverOnDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateLeverOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLeverOn : TriggerState {
            internal StateLeverOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002029}, arg2: 1);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002029}, arg2: 0)) {
                    context.State = new StateTrapOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTrapOn : TriggerState {
            internal StateTrapOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203, 303}, arg2: false);
                context.SetMesh(arg1: new[] {3430, 3431, 3432, 3433}, arg2: false, arg3: 500, arg4: 0, arg5: 2f);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateRemove(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {203, 303});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}