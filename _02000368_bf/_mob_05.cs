namespace Maple2.Trigger._02000368_bf {
    public static class _mob_05 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7501}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State전투01(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State전투01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {501, 511}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {501, 511})) {
                    context.State = new State전투02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {7501}, arg2: true);
                context.CreateMonster(arg1: new[] {502}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {502})) {
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