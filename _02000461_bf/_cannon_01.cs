namespace Maple2.Trigger._02000461_bf {
    public static class _cannon_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {691}, arg2: false);
                context.SetMesh(arg1: new[] {3901}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "cannon01") == 1) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2901}, arg2: true);
                context.AddBuff(arg1: new[] {2901}, arg2: 40444001, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2901})) {
                    context.SetEffect(arg1: new[] {691}, arg2: true);
                    context.SetMesh(arg1: new[] {3901}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
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