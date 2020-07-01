using System;

namespace Maple2.Trigger._02010054_bf {
    public static class _brick_25 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {34025}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7025}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1125})) {
                    context.State = new State발판(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판 : TriggerState {
            internal State발판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {7025}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.SetMesh(arg1: new int[] {34025}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}