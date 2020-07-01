using System;

namespace Maple2.Trigger._02000355_bf {
    public static class _actor11 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetActor(arg1: 211, arg2: true, arg3: "Damg_B");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {11001})) {
                    context.State = new State몬스터소환대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환대기 : TriggerState {
            internal State몬스터소환대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {611}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State더미해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State더미해제 : TriggerState {
            internal State더미해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: false, arg3: "Damg_B");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2011})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.NpcDetected(arg1: 105, arg2: new int[] {2011})) {
                    context.DestroyMonster(arg1: new int[] {2011});
                    context.State = new State리젠준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State리젠준비(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리젠준비 : TriggerState {
            internal State리젠준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 211, arg2: true, arg3: "Regen_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {2011});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}