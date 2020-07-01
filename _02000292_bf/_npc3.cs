namespace Maple2.Trigger._02000292_bf {
    public static class _npc3 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000622}, arg2: 1);
                context.DestroyMonster(arg1: new[] {1100});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000622}, arg2: 0)) {
                    context.State = new StateNPC대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC대사 : TriggerState {
            internal StateNPC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000622}, arg2: 2);
                context.CreateMonster(arg1: new[] {1100});
                context.SetConversation(arg1: 1, arg2: 1100, arg3: "$02000292_BF__NPC3__0$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1100, arg3: "$02000292_BF__NPC3__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1100});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}