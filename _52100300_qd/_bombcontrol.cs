namespace Maple2.Trigger._52100300_qd {
    public static class _bombcontrol {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "RandomBombEnd", value: 0);
                context.StartCombineSpawn(groupId: new[] {522}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {523}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {524}, isStart: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "RandomBomb") == 1) {
                    context.State = new State포탑생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑생성_1 : TriggerState {
            internal State포탑생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {152}, arg2: true);
                context.StartCombineSpawn(groupId: new[] {524}, isStart: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {152})) {
                    context.State = new State포탑생성_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑생성_2 : TriggerState {
            internal State포탑생성_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {522}, isStart: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new State포탑생성_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탑생성_3 : TriggerState {
            internal State포탑생성_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {523}, isStart: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {151, 152, 153, 154, 155, 156, 157, 158, 159})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "RandomBombEnd", value: 1);
                context.StartCombineSpawn(groupId: new[] {522}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {523}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {524}, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}