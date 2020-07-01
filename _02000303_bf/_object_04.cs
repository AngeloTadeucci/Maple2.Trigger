namespace Maple2.Trigger._02000303_bf {
    public static class _object_04 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000601}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000602}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000603}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000604}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000605}, arg2: 0);
                context.SetEffect(arg1: new[] {60601}, arg2: false);
                context.SetEffect(arg1: new[] {60602}, arg2: false);
                context.SetEffect(arg1: new[] {60603}, arg2: false);
                context.SetEffect(arg1: new[] {60604}, arg2: false);
                context.SetEffect(arg1: new[] {60605}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성랜덤 : TriggerState {
            internal State생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State생성05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성01 : TriggerState {
            internal State생성01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60601}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000601}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000601}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60601}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성02 : TriggerState {
            internal State생성02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60602}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000602}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000602}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60602}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성03 : TriggerState {
            internal State생성03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60603}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000603}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000603}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60603}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성04 : TriggerState {
            internal State생성04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60604}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000604}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000604}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60604}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성05 : TriggerState {
            internal State생성05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60605}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000605}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000605}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60605}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}