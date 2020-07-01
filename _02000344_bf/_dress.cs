namespace Maple2.Trigger._02000344_bf {
    public static class _dress {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {6711, 6712, 6713, 6714, 6715}, arg2: false, arg3: 0, arg4: 10);
                context.SetInteractObject(arg1: new[] {10001066}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60002) == 1) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003441, textId: 20003441, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000344_BF__DRESS__0$", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6701, 6702, 6703, 6704, 6705}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {6711, 6712, 6713, 6714, 6715}, arg2: true, arg3: 0, arg4: 10);
                context.ShowGuideSummary(entityId: 20003444, textId: 20003444, duration: 5000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}