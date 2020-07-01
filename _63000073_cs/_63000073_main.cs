namespace Maple2.Trigger._63000073_cs {
    public static class _63000073_main {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117}, arg2: true);
                context.SetLadder(arg1: 6001, arg2: false, arg3: false);
                context.SetLadder(arg1: 6002, arg2: false, arg3: false);
                context.SetLadder(arg1: 6003, arg2: false, arg3: false);
                context.SetLadder(arg1: 6004, arg2: false, arg3: false);
                context.SetMesh(arg1: new[] {4001}, arg2: true);
                context.SetMesh(arg1: new[] {4002}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000372}, arg3: new byte[] {3})) {
                    context.State = new State전투만(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000372}, arg3: new byte[] {2})) {
                    context.State = new State퀘완료가능재입장(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {30000372}, arg3: new byte[] {1})) {
                    context.State = new State잠시대기_01(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new State전투만(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투만 : TriggerState {
            internal State전투만(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {115})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetLadder(arg1: 6001, arg2: true, arg3: true);
                context.SetLadder(arg1: 6002, arg2: true, arg3: true);
                context.SetLadder(arg1: 6003, arg2: true, arg3: true);
                context.SetLadder(arg1: 6004, arg2: true, arg3: true);
            }
        }

        private class State잠시대기_01 : TriggerState {
            internal State잠시대기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {121}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State잠시대기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State잠시대기_02 : TriggerState {
            internal State잠시대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스퇴장_01 : TriggerState {
            internal State보보스퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "보보스퇴장_03", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스퇴장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스퇴장_02 : TriggerState {
            internal State보보스퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 121, arg2: "MS2PatrolData_2001");
                context.AddBalloonTalk(spawnPointId: 121, msg: "$63000073_CS__63000073_MAIN__0$", duration: 2500, delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보보스퇴장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보보스퇴장_03 : TriggerState {
            internal State보보스퇴장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보보스퇴장_04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {121});
            }
        }

        private class State보보스퇴장_04 : TriggerState {
            internal State보보스퇴장_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityId: 26300731, textId: 26300731);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {115})) {
                    context.State = new State사다리등장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사다리등장_01 : TriggerState {
            internal State사다리등장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300731);
                context.SetLadder(arg1: 6001, arg2: true, arg3: true);
                context.SetLadder(arg1: 6002, arg2: true, arg3: true);
                context.SetLadder(arg1: 6003, arg2: true, arg3: true);
                context.SetLadder(arg1: 6004, arg2: true, arg3: true);
                context.ShowGuideSummary(entityId: 26300733, textId: 26300733);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001385}, arg2: 0)) {
                    context.State = new State트렁크오픈_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_01 : TriggerState {
            internal State트렁크오픈_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 26300733);
                context.CreateMonster(arg1: new[] {122}, arg2: false);
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.SetMesh(arg1: new[] {4002}, arg2: true);
                context.ShowGuideSummary(entityId: 26300732, textId: 26300732);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {702}, arg2: new[] {30000372}, arg3: new byte[] {2})) {
                    context.State = new State트렁크오픈_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘완료가능재입장 : TriggerState {
            internal State퀘완료가능재입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {122}, arg2: false);
                context.SetMesh(arg1: new[] {4001}, arg2: false);
                context.SetMesh(arg1: new[] {4002}, arg2: true);
                context.SetLadder(arg1: 6001, arg2: true, arg3: true);
                context.SetLadder(arg1: 6002, arg2: true, arg3: true);
                context.SetLadder(arg1: 6003, arg2: true, arg3: true);
                context.SetLadder(arg1: 6004, arg2: true, arg3: true);
                context.MoveUser(arg1: 63000073, arg2: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State트렁크오픈_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_02 : TriggerState {
            internal State트렁크오픈_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.HideGuideSummary(entityId: 26300732);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State트렁크오픈_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_03 : TriggerState {
            internal State트렁크오픈_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_2002");
                context.CameraSelectPath(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트렁크오픈_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트렁크오픈_04 : TriggerState {
            internal State트렁크오픈_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_halfsec.xml");
                context.SetSceneSkip(arg1: "에이든퇴장_01", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State에이든대화_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_01 : TriggerState {
            internal State에이든대화_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 122, arg2: "Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에이든대화_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_02 : TriggerState {
            internal State에이든대화_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004359, msg: "$63000073_CS__63000073_MAIN__1$", duration: 2500, align: "right", illustId: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에이든대화_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_03 : TriggerState {
            internal State에이든대화_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에이든대화_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_04 : TriggerState {
            internal State에이든대화_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2500f);
                context.AddCinematicTalk(npcId: 0, msg: "$63000073_CS__63000073_MAIN__2$", duration: 2500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State에이든대화_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_05 : TriggerState {
            internal State에이든대화_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 2500f);
                context.AddCinematicTalk(npcId: 0, msg: "$63000073_CS__63000073_MAIN__3$", duration: 4500, align: "right");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에이든대화_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_06 : TriggerState {
            internal State에이든대화_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {8003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State에이든대화_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_07 : TriggerState {
            internal State에이든대화_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 3500f);
                context.AddCinematicTalk(npcId: 11004359, msg: "$63000073_CS__63000073_MAIN__4$", duration: 3500, align: "right", illustId: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State에이든대화_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든대화_08 : TriggerState {
            internal State에이든대화_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 122, arg2: "Talk_A", arg3: 4500f);
                context.AddCinematicTalk(npcId: 11004359, msg: "$63000073_CS__63000073_MAIN__5$", duration: 4500, align: "right", illustId: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State에이든퇴장_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State에이든퇴장_01 : TriggerState {
            internal State에이든퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {122});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}