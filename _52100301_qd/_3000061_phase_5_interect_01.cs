namespace Maple2.Trigger._52100301_qd {
    public static class _3000061_phase_5_interect_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200031, 200032}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Phase_5_Interect_01") == 1) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$52100301_QD__3000061_PHASE_5_INTERECT_01__0$", arg3: 4000);
                context.CreateMonster(arg1: new[] {999}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State탈것_등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State탈것_등장 : TriggerState {
            internal State탈것_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003126}, arg2: 1);
                context.DestroyMonster(arg1: new[] {999});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003126}, arg2: 0)) {
                    context.State = new State인터렉트_동작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_동작 : TriggerState {
            internal State인터렉트_동작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State인터렉트_리셋(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State인터렉트_리셋 : TriggerState {
            internal State인터렉트_리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckAnyUserAdditionalEffect(triggerBoxId: 0, additionalEffectId: 62100152, level: true)) {
                    context.State = new State리셋_대기(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋_대기 : TriggerState {
            internal State리셋_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.GetUserValue(key: "Phase_5_Interect_01") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}