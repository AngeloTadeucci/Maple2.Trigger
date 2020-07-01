namespace Maple2.Trigger._02000331_bf {
    public static class _switch09 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7773}, arg2: false);
                context.SetBreakable(arg1: new[] {5001}, arg2: false);
                context.SetBreakable(arg1: new[] {5002}, arg2: false);
                context.SetBreakable(arg1: new[] {5011}, arg2: false);
                context.SetBreakable(arg1: new[] {5012}, arg2: false);
                context.SetBreakable(arg1: new[] {5021}, arg2: false);
                context.SetBreakable(arg1: new[] {5022}, arg2: false);
                context.SetBreakable(arg1: new[] {5031}, arg2: false);
                context.SetBreakable(arg1: new[] {5032}, arg2: false);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000795}, arg2: 0)) {
                    context.State = new State발판내리기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판내리기 : TriggerState {
            internal State발판내리기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {5001}, arg2: true);
                context.SetBreakable(arg1: new[] {5002}, arg2: true);
                context.SetBreakable(arg1: new[] {5011}, arg2: true);
                context.SetBreakable(arg1: new[] {5012}, arg2: true);
                context.SetBreakable(arg1: new[] {5021}, arg2: true);
                context.SetBreakable(arg1: new[] {5022}, arg2: true);
                context.SetBreakable(arg1: new[] {5031}, arg2: true);
                context.SetBreakable(arg1: new[] {5032}, arg2: true);
                context.SetEffect(arg1: new[] {7773}, arg2: true);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {5001}, arg2: false);
                context.SetBreakable(arg1: new[] {5002}, arg2: false);
                context.SetBreakable(arg1: new[] {5011}, arg2: false);
                context.SetBreakable(arg1: new[] {5012}, arg2: false);
                context.SetBreakable(arg1: new[] {5021}, arg2: false);
                context.SetBreakable(arg1: new[] {5022}, arg2: false);
                context.SetBreakable(arg1: new[] {5031}, arg2: false);
                context.SetBreakable(arg1: new[] {5032}, arg2: false);
                context.SetEffect(arg1: new[] {7773}, arg2: false);
                context.SetMesh(arg1: new[] {40000, 40001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}