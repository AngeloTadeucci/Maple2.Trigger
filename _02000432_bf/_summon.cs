namespace Maple2.Trigger._02000432_bf {
    public static class _summon {
        public class State룸체크 : TriggerState {
            internal State룸체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new State소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "죽음대기");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State죽음대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State죽음대기 : TriggerState {
            internal State죽음대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State셀린사망(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.State = new State피리스사망(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State셀린사망 : TriggerState {
            internal State셀린사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 2002, arg3: "$02000432_BF__SUMMON__1$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2002}, arg2: 40500011, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State피리스사망 : TriggerState {
            internal State피리스사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "BigSisterFirst");
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000432_BF__SUMMON__0$", arg4: 4, arg5: 0);
                context.AddBuff(arg1: new[] {2001}, arg2: 40500011, arg3: 1, arg4: true, arg5: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "SirenDualKill");
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
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