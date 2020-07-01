namespace Maple2.Trigger._52000023_qd {
    public static class _main01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000, 5001, 6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009}, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000617, 10000618, 10000619}, arg2: 0);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {20002230}, arg3: new byte[] {1})) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: true);
                context.CreateMonster(arg1: new[] {101, 901, 902, 903, 904, 905, 906, 907, 908, 909, 910}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State유저이동01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State유저이동01 : TriggerState {
            internal State유저이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State유저이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동02 : TriggerState {
            internal State유저이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_100");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new State유저이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동03 : TriggerState {
            internal State유저이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {601, 602}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투준비01 : TriggerState {
            internal State전투준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__0$", arg4: 6, arg5: 0);
                context.SetSkip(arg1: "전투준비02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State전투준비02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State전투준비02 : TriggerState {
            internal State전투준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: false);
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__1$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "전투시작");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 603, arg2: false);
                context.SetAgent(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    context.State = new State대화준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화준비01 : TriggerState {
            internal State대화준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대화준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화준비02 : TriggerState {
            internal State대화준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_200");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new State대화준비03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화준비03 : TriggerState {
            internal State대화준비03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이슈라대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대화01 : TriggerState {
            internal State이슈라대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__2$", arg4: 8, arg5: 0);
                context.SetSkip(arg1: "이슈라대화02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State이슈라대화02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State이슈라대화02 : TriggerState {
            internal State이슈라대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: false);
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__3$", arg4: 8, arg5: 0);
                context.SetSkip(arg1: "이슈라대화03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State이슈라대화03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State이슈라대화03 : TriggerState {
            internal State이슈라대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6004}, arg2: false);
                context.SetEffect(arg1: new[] {6005}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__4$", arg4: 7, arg5: 0);
                context.SetSkip(arg1: "이슈라대화04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State이슈라대화04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State이슈라대화04 : TriggerState {
            internal State이슈라대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6005}, arg2: false);
                context.SetEffect(arg1: new[] {6006}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__5$", arg4: 6, arg5: 0);
                context.SetSkip(arg1: "수색준비");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State수색준비(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class State수색준비 : TriggerState {
            internal State수색준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6006}, arg2: false);
                context.DestroyMonster(arg1: new[] {102});
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000617, 10000618, 10000619}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State수색시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수색시작 : TriggerState {
            internal State수색시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 25200231, textId: 25200231);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000617}, arg2: 0)) {
                    context.State = new State수색종료01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }
        }

        private class State수색종료01 : TriggerState {
            internal State수색종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000618, 10000619}, arg2: 0);
                context.HideGuideSummary(entityId: 25200231);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State수색종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수색종료02 : TriggerState {
            internal State수색종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
                context.SetEffect(arg1: new[] {6007}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$52000023_QD__MAIN01__6$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State정리준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리준비01 : TriggerState {
            internal State정리준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.CameraSelect(arg1: 604, arg2: true);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {103})) {
                    context.State = new State정리준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리준비02 : TriggerState {
            internal State정리준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6007}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State정리대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리대화01 : TriggerState {
            internal State정리대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6008}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__7$", arg4: 9, arg5: 0);
                context.SetSkip(arg1: "정리대화02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State정리대화02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State정리대화02 : TriggerState {
            internal State정리대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6008}, arg2: false);
                context.SetEffect(arg1: new[] {6009}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001244, arg3: "$52000023_QD__MAIN01__8$", arg4: 5, arg5: 0);
                context.SetSkip(arg1: "퇴장준비");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State퇴장준비(context);
                    return;
                }
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class State퇴장준비 : TriggerState {
            internal State퇴장준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 604, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State퇴장중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퇴장중 : TriggerState {
            internal State퇴장중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "MeetAgain_Ishura");
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {103})) {
                    context.State = new State퇴장완료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103});
            }
        }

        private class State퇴장완료 : TriggerState {
            internal State퇴장완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6009}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}