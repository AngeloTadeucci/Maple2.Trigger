namespace Maple2.Trigger._80000008_bonus {
    public static class _trigger_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000209}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000209}, arg2: 0)) {
                    context.State = new State소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 401, arg2: new[] {102})) {
                    context.State = new State몬스터소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetTimer(arg1: "2", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State아이템(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아이템 : TriggerState {
            internal State아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {501});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}