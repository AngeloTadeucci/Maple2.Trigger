using System;

namespace Maple2.Trigger._52100021_qd {
    public static class _4000_ladder {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 4003, arg2: false, arg3: false, arg4: 0);
                context.SetInteractObject(arg1: new int[] {10001128}, arg2: 0, arg4: false);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9100, arg2: new int[] {101})) {
                    context.State = new StatePCComeDown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCComeDown : TriggerState {
            internal StatePCComeDown(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9300})) {
                    context.State = new StateLadderOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLadderOn : TriggerState {
            internal StateLadderOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 4001, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4002, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 4003, arg2: true, arg3: true, arg4: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}