namespace Maple2.Trigger._02000378_bf {
    public static class _04_findway {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 21, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {4024, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3004}, arg2: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(arg1: new[] {3104}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5204}, arg2: false);
                context.SetUserValue(key: "FindWay", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "FindWay") == 1) {
                    context.State = new StateReadyToWalkIn_FromPortal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToWalkIn_FromPortal : TriggerState {
            internal StateReadyToWalkIn_FromPortal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {4024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerId: 1304, key: "RouteSelected", value: 1);
                context.SetUserValue(triggerId: 2304, key: "RouteSelected", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToWalkIn_FromPortal02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {2004, 104}, arg2: false);
            }
        }

        private class StateReadyToWalkIn_FromPortal02 : TriggerState {
            internal StateReadyToWalkIn_FromPortal02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000378_BF__04_FINDWAY__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound04_Start(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {104});
            }
        }

        private class StateRound04_Start : TriggerState {
            internal StateRound04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$02000378_BF__04_FINDWAY__4$", arg4: 3, arg5: 2);
                context.SetUserValue(triggerId: 904, key: "MobWaveStart", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "04RoundSuccess") == 1) {
                    context.State = new StateRound04_Sucess02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound04_Sucess02 : TriggerState {
            internal StateRound04_Sucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2004, arg2: "MS2PatrolData_2004");
                context.DestroyMonster(arg1: new[] {1004});
                context.CreateMonster(arg1: new[] {104}, arg2: false);
                context.SetMesh(arg1: new[] {3004}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {3004}, arg2: false, arg3: 0, arg4: 0);
                context.SetEffect(arg1: new[] {5204}, arg2: true);
                context.SetPortal(arg1: 21, arg2: true, arg3: true, arg4: false);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000378_BF__04_FINDWAY__5$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateRound04_RouteSelect(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound04_RouteSelect : TriggerState {
            internal StateRound04_RouteSelect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2004});
                context.CreateMonster(arg1: new[] {204}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104New");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGoToRound12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGoToRound12 : TriggerState {
            internal StateGoToRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204New");
                context.SetUserValue(triggerId: 12, key: "FindWay", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {204});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}