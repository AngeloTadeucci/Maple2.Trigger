namespace Maple2.Trigger._61000001_me_001 {
    public static class _massive00 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.State = new State퍼즐대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐대기중 : TriggerState {
            internal State퍼즐대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1,
                    arg2:
                    "퍼즐패턴10,퍼즐패턴11,퍼즐패턴12,퍼즐패턴13,퍼즐패턴14,퍼즐패턴15,퍼즐패턴16,퍼즐패턴17,퍼즐패턴18,퍼즐패턴19,퍼즐패턴20,퍼즐패턴21,퍼즐패턴22,퍼즐패턴23,퍼즐패턴24,퍼즐패턴25,퍼즐패턴26,퍼즐패턴27,퍼즐패턴28,퍼즐패턴29,퍼즐패턴30,퍼즐패턴31,퍼즐패턴32,퍼즐패턴33,퍼즐패턴34,퍼즐패턴35,퍼즐패턴36,퍼즐패턴37,퍼즐패턴38,퍼즐패턴39,퍼즐패턴40,퍼즐패턴41,퍼즐패턴42,퍼즐패턴43,퍼즐패턴44,퍼즐패턴45,퍼즐패턴46,퍼즐패턴47,퍼즐패턴48,퍼즐패턴49,퍼즐패턴50,퍼즐패턴51,퍼즐패턴52,퍼즐패턴53,퍼즐패턴54,퍼즐패턴55,퍼즐패턴56,퍼즐패턴57,퍼즐패턴58,퍼즐패턴59,퍼즐패턴60",
                    arg3: true);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: true);
                context.SetPortal(arg1: 778, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 779, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 301) == 50) {
                    context.State = new State계단없애기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 60000)) {
                    context.State = new State계단없애기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State계단없애기 : TriggerState {
            internal State계단없애기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMiniGameAreaForHack(boxId: 301);
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Vanished");
                context.SetPortal(arg1: 777, arg2: false, arg3: false, arg4: false);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State계단없애기2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State계단없애기2 : TriggerState {
            internal State계단없애기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210, 211}, arg2: false);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 261, arg2: false, arg3: "Eff_MassiveEvent_Door_Vanished");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetState(arg1: 1,
                    arg2:
                    "퍼즐패턴10,퍼즐패턴11,퍼즐패턴12,퍼즐패턴13,퍼즐패턴14,퍼즐패턴15,퍼즐패턴16,퍼즐패턴17,퍼즐패턴18,퍼즐패턴19,퍼즐패턴20,퍼즐패턴21,퍼즐패턴22,퍼즐패턴23,퍼즐패턴24,퍼즐패턴25,퍼즐패턴26,퍼즐패턴27,퍼즐패턴28,퍼즐패턴29,퍼즐패턴30,퍼즐패턴31,퍼즐패턴32,퍼즐패턴33,퍼즐패턴34,퍼즐패턴35,퍼즐패턴36,퍼즐패턴37,퍼즐패턴38,퍼즐패턴39,퍼즐패턴40,퍼즐패턴41,퍼즐패턴42,퍼즐패턴43,퍼즐패턴44,퍼즐패턴45,퍼즐패턴46,퍼즐패턴47,퍼즐패턴48,퍼즐패턴49,퍼즐패턴50,퍼즐패턴51,퍼즐패턴52,퍼즐패턴53,퍼즐패턴54,퍼즐패턴55,퍼즐패턴56,퍼즐패턴57,퍼즐패턴58,퍼즐패턴59,퍼즐패턴60",
                    arg3: true);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: false);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 256, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 257, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 258, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 259, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(arg1: 260, arg2: false, arg3: "Eff_MassiveEvent_Stair_Closed");
                context.SetTimer(arg1: "1", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트0(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트0 : TriggerState {
            internal State멘트0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 5);
                context.PlaySystemSoundInBox(arg2: "ME_001_Massive00_00");
                context.SetEventUI(arg1: 1, arg2: "$61000001_ME_001__MASSIVE00__0$", arg3: 6000);
                context.StartMiniGame(boxId: 301, round: 5, gameName: "trapmaster");
                context.SetAchievement(arg1: 301, arg2: "trigger", arg3: "trapmaster_start");
                context.SetAchievement(arg1: 301, arg2: "trigger", arg3: "dailyquest_start");
                context.GiveGuildExp(boxId: false, type: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트1 : TriggerState {
            internal State멘트1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 11);
                context.PlaySystemSoundInBox(arg2: "ME_001_Massive00_01");
                context.SetEventUI(arg1: 1, arg2: "$61000001_ME_001__MASSIVE00__1$", arg3: 11000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트2 : TriggerState {
            internal State멘트2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10);
                context.PlaySystemSoundInBox(arg2: "ME_001_Massive00_02");
                context.SetEventUI(arg1: 1, arg2: "$61000001_ME_001__MASSIVE00__2$", arg3: 10000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State멘트3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State멘트3 : TriggerState {
            internal State멘트3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
                context.SetEventUI(arg1: 0, arg2: "1,5");
                context.ShowCountUI(text: "$61000001_ME_001__MASSIVE00__3$", stage: 1, count: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계1(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1 : TriggerState {
            internal State퍼즐단계1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
                context.StartMiniGameRound(boxId: 301, round: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State퍼즐단계1정리(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계1정리 : TriggerState {
            internal State퍼즐단계1정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(arg1: "1", arg2: 3);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계1종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계1종료 : TriggerState {
            internal State퍼즐단계1종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "2,5");
                    context.ShowCountUI(text: "$61000001_ME_001__MASSIVE00__4$", stage: 2, count: 5);
                    context.State = new State퍼즐단계2대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계2대기 : TriggerState {
            internal State퍼즐단계2대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2 : TriggerState {
            internal State퍼즐단계2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 2);
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State퍼즐단계2정리(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계2정리 : TriggerState {
            internal State퍼즐단계2정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계2종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계2종료 : TriggerState {
            internal State퍼즐단계2종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "3,5");
                    context.ShowCountUI(text: "$61000001_ME_001__MASSIVE00__5$", stage: 3, count: 5);
                    context.State = new State퍼즐단계3대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계3대기 : TriggerState {
            internal State퍼즐단계3대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3 : TriggerState {
            internal State퍼즐단계3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 3);
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State퍼즐단계3정리(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계3정리 : TriggerState {
            internal State퍼즐단계3정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계3종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계3종료 : TriggerState {
            internal State퍼즐단계3종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "4,5");
                    context.ShowCountUI(text: "$61000001_ME_001__MASSIVE00__6$", stage: 4, count: 5);
                    context.State = new State퍼즐단계4대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계4대기 : TriggerState {
            internal State퍼즐단계4대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계4(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계4 : TriggerState {
            internal State퍼즐단계4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 4);
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State퍼즐단계4정리(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계4정리 : TriggerState {
            internal State퍼즐단계4정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계4종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계4종료 : TriggerState {
            internal State퍼즐단계4종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetEventUI(arg1: 0, arg2: "5,5");
                    context.ShowCountUI(text: "$61000001_ME_001__MASSIVE00__7$", stage: 5, count: 5);
                    context.State = new State퍼즐단계5대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐단계5대기 : TriggerState {
            internal State퍼즐단계5대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계5(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계5 : TriggerState {
            internal State퍼즐단계5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartMiniGameRound(boxId: 301, round: 5);
                context.SetTimer(arg1: "99", arg2: 14);
                context.UseState(arg1: 1, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "99")) {
                    context.State = new State퍼즐단계5정리(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "99");
            }
        }

        private class State퍼즐단계5정리 : TriggerState {
            internal State퍼즐단계5정리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301, expRate: 0.2f);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐단계5종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐단계5종료 : TriggerState {
            internal State퍼즐단계5종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {301})) {
                    context.SetMesh(
                        arg1: new[] {
                            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25,
                            26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48,
                            49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71,
                            72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94,
                            95, 96, 97, 98, 99, 100
                        }, arg2: true);
                    context.State = new State우승자카메라연출(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {301})) {
                    context.State = new State실패계단보이기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State우승자카메라연출 : TriggerState {
            internal State우승자카메라연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MiniGameCameraDirection(boxId: 301, cameraId: 901);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.PlaySystemSoundInBox(arg1: new[] {301}, arg2: "ME_001_Massive00_08");
                context.SetEventUI(arg1: 3, arg2: "$61000001_ME_001__MASSIVE00__8$", arg3: 7000,
                    arg4: "301");
                context.SetEventUI(arg1: 6, arg2: "$61000001_ME_001__MASSIVE00__9$", arg3: 7000,
                    arg4: "!301");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetLocalCamera(cameraId: 901, enable: false);
                    context.State = new State보상단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보상단계 : TriggerState {
            internal State보상단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {301}, arg2: 70000019, arg3: 1);
                context.PlaySystemSoundInBox(arg1: new[] {301}, arg2: "ME_001_Massive00_10");
                context.SetEventUI(arg1: 3, arg2: "$61000001_ME_001__MASSIVE00__10$", arg3: 5000,
                    arg4: "301");
                context.SetEventUI(arg1: 6, arg2: "$61000001_ME_001__MASSIVE00__11$", arg3: 5000,
                    arg4: "!301");
                context.MiniGameGiveReward(winnerBoxId: 301, contentType: "miniGame");
                context.EndMiniGame(winnerBoxId: 301, gameName: "trapmaster");
                context.SetAchievement(arg1: 301, arg2: "trigger", arg3: "trapmaster_win");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State퍼즐종료계단보이기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐종료계단보이기 : TriggerState {
            internal State퍼즐종료계단보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐종료계단보이기2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐종료계단보이기2 : TriggerState {
            internal State퍼즐종료계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210}, arg2: true);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State퍼즐종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State퍼즐종료 : TriggerState {
            internal State퍼즐종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.UnSetMiniGameAreaForHack();
                context.SetMesh(arg1: new[] {211}, arg2: true);
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State퍼즐종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐종료2 : TriggerState {
            internal State퍼즐종료2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퍼즐패턴10 : TriggerState {
            internal State퍼즐패턴10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴11 : TriggerState {
            internal State퍼즐패턴11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93,
                        92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69, 79,
                        89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 23, 24, 25, 26, 27, 28, 38, 48, 58, 68,
                        78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 34, 35, 36, 37, 47, 57, 67, 66, 65, 64, 54, 44
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴12 : TriggerState {
            internal State퍼즐패턴12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 31, 41, 42, 43, 44,
                        45, 46, 47, 48, 49, 50, 60, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 71, 81, 82, 83, 84, 85, 86,
                        87, 88, 89, 90, 100
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴13 : TriggerState {
            internal State퍼즐패턴13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 11, 12, 13, 14, 15, 16,
                        17, 18, 19, 20, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30,
                        80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 70, 69, 68, 67,
                        66, 65, 64, 63, 62, 61
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴14 : TriggerState {
            internal State퍼즐패턴14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 80, 79, 78, 77, 76, 75, 74, 73, 72, 71, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴15 : TriggerState {
            internal State퍼즐패턴15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93,
                        92, 91, 81, 71, 61, 51, 41, 31, 21, 11
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {23, 24, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33},
                    arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {45, 46, 55, 56}, arg2: false, arg3: 5600, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴16 : TriggerState {
            internal State퍼즐패턴16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100, 89, 78, 67, 56, 45, 34, 23, 12, 11, 21, 31, 41, 51, 61, 71, 81, 83, 84, 85, 86, 87, 88,
                        90, 80, 70, 60, 50, 40, 30, 20, 18, 17, 16, 15, 14, 13, 22, 32, 42, 52, 62, 72, 74, 75, 76, 77,
                        79, 69, 59, 49, 39, 29, 27, 26, 25, 24
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴17 : TriggerState {
            internal State퍼즐패턴17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 19, 28, 37, 46, 55, 64, 73, 82, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 18, 17, 16, 15, 14, 13, 12, 11, 21, 31, 41, 51, 61, 71,
                        81, 83, 84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 29, 27, 26, 25, 24, 23, 22, 32, 42, 52, 62,
                        72, 74, 75, 76, 77, 78, 68, 58, 48, 38, 36, 35, 34, 33, 43, 53, 63, 65, 66, 67
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴18 : TriggerState {
            internal State퍼즐패턴18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 80, 79, 78, 77,
                        76, 75, 74, 73, 72, 71, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 30, 29, 28, 27, 26, 25,
                        24, 23, 22, 21, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 50, 49, 48, 47, 46, 45, 44, 43, 42, 41,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true, arg3: 1200, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴19 : TriggerState {
            internal State퍼즐패턴19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 21, 22, 23, 24,
                        25, 26, 27, 28, 29, 30, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 80, 79, 78, 77,
                        76, 75, 74, 73, 72, 71, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴20 : TriggerState {
            internal State퍼즐패턴20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 21, 31,
                        32, 33, 34, 35, 36, 37, 38, 39, 29, 19, 18, 17, 16, 15, 14, 13, 12, 22
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 90,
                        80, 70, 69, 68, 67, 66, 65, 64, 63, 62, 72, 82, 83, 84, 85, 86, 87, 88, 89, 79
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴21 : TriggerState {
            internal State퍼즐패턴21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 19, 29, 39, 38, 28, 18, 8, 7, 17, 27,
                        37, 36, 26, 16, 6, 5, 15, 25, 35, 34, 24, 14, 4, 3, 13, 23, 33, 32, 22, 12, 2
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 82, 72, 62, 63, 73, 83, 93, 94, 84,
                        74, 64, 65, 75, 85, 95, 96, 86, 76, 66, 67, 77, 87, 97, 98, 88, 78, 68, 69, 79, 89, 99
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴22 : TriggerState {
            internal State퍼즐패턴22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 40, 30, 20, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 11, 12, 13,
                        14, 15, 16, 17, 18, 19, 29, 28, 27, 26, 25, 24, 23, 22, 21, 31
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 90,
                        89, 88, 87, 86, 85, 84, 83, 82, 72, 73, 74, 75, 76, 77, 78, 79, 80, 70
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴23 : TriggerState {
            internal State퍼즐패턴23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 31, 32, 33, 34, 35, 36,
                        37, 38, 39, 40, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 70, 69, 68, 67,
                        66, 65, 64, 63, 62, 61, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴24 : TriggerState {
            internal State퍼즐패턴24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 21, 22, 23, 24,
                        25, 26, 27, 28, 29, 30, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        50, 49, 48, 47, 46, 45, 44, 43, 42, 41, 40, 39, 38, 37, 36, 35, 34, 33, 32, 31, 30, 29, 28, 27,
                        26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
                    }, arg2: true, arg3: 1200, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        60, 59, 58, 57, 56, 55, 54, 53, 52, 51, 70, 69, 68, 67, 66, 65, 64, 63, 62, 61, 80, 79, 78, 77,
                        76, 75, 74, 73, 72, 71, 90, 89, 88, 87, 86, 85, 84, 83, 82, 81, 100, 99, 98, 97, 96, 95, 94, 93,
                        92, 91
                    }, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true, arg3: 1200, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴25 : TriggerState {
            internal State퍼즐패턴25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetTimer(arg1: "1", arg2: 10);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴26 : TriggerState {
            internal State퍼즐패턴26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 30, 50, 70, 90}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {19, 39, 59, 79, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 28, 48, 68, 88}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {17, 37, 57, 77, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 26, 46, 66, 86}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 21, 41, 61, 81}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {12, 32, 52, 72, 92}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 23, 43, 63, 83}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {14, 34, 54, 74, 94}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 25, 45, 65, 85}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴27 : TriggerState {
            internal State퍼즐패턴27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 30, 50, 70, 90}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {19, 39, 59, 79, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 28, 48, 68, 88}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {17, 37, 57, 77, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 26, 46, 66, 86}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {15, 35, 55, 75, 95}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 24, 44, 64, 84}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {13, 33, 53, 73, 93}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 22, 42, 62, 82}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 31, 51, 71, 91}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴28 : TriggerState {
            internal State퍼즐패턴28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 67, 78, 89, 100}, arg2: false, arg3: 4500,
                    arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 5000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 5500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 6000, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 6500, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 7000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 8000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 8500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 9000, arg4: 0);
                context.SetMesh(arg1: new[] {10}, arg2: true, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: true, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: true, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: true, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: true, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: true, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: true, arg3: 4500, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: true, arg3: 5000, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: true, arg3: 5500, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 67, 78, 89, 100}, arg2: true, arg3: 6000,
                    arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: true, arg3: 6500, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: true, arg3: 7000, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: true, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: true, arg3: 8000, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: true, arg3: 8500, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: true, arg3: 9000, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: true, arg3: 9500, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: true, arg3: 10000, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: true, arg3: 10500, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴29 : TriggerState {
            internal State퍼즐패턴29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴30 : TriggerState {
            internal State퍼즐패턴30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100,
                    arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23, 22, 21}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78, 88, 98}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34, 33, 32, 31}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67, 77, 87, 97}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {45, 44, 43, 42, 41}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {56, 66, 76, 86, 96}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {54, 53, 52, 51}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {65, 75, 85, 95}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 3900, arg4: 0);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 4200, arg4: 0);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 4300, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴31 : TriggerState {
            internal State퍼즐패턴31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100,
                    arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {72, 62, 52, 42, 32, 22}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {83, 84, 85, 86, 87, 88}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 3900, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67}, arg2: false, arg3: 4000, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 4200, arg4: 0);
                context.SetMesh(arg1: new[] {54, 44}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {65, 66}, arg2: false, arg3: 4300, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴32 : TriggerState {
            internal State퍼즐패턴32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 100,
                    arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23, 22}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78, 88}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33, 13}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77, 79}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {45, 44, 42}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {56, 66, 86}, arg2: false, arg3: 3100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {35, 15}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {57, 59}, arg2: false, arg3: 3600, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴33 : TriggerState {
            internal State퍼즐패턴33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 29, 39, 49, 59, 69, 79, 89, 99}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 18, 38, 48, 58, 68, 78, 88, 98}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 17, 27, 47, 57, 67, 77, 87, 97}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {6, 16, 26, 36, 56, 66, 76, 86, 96}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 15, 25, 35, 45, 65, 75, 85, 95}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 14, 24, 34, 44, 54, 74, 84, 94}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 13, 23, 33, 43, 53, 63, 83, 93}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 12, 22, 32, 42, 52, 62, 72, 92}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 11, 21, 31, 41, 51, 61, 71, 81}, arg2: false, arg3: 4500, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴34 : TriggerState {
            internal State퍼즐패턴34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        46, 56, 55, 45, 35, 36, 37, 47, 57, 67, 66, 65, 64, 54, 44, 34, 24, 25, 26, 27, 28, 38, 48, 58,
                        68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 23, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49, 59, 69,
                        79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 12
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴35 : TriggerState {
            internal State퍼즐패턴35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        46, 56, 55, 45, 25, 26, 27, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 23, 24,
                        30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21,
                        11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴36 : TriggerState {
            internal State퍼즐패턴36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        46, 56, 55, 45, 35, 25, 15, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97,
                        96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39,
                        49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22, 23, 24, 25, 26, 27, 28,
                        38, 48, 58, 68, 78, 77, 76, 75, 74, 73, 63, 53, 43, 33, 34, 35, 36, 37, 47, 57, 67, 66, 65, 64,
                        54, 44
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴37 : TriggerState {
            internal State퍼즐패턴37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        46, 56, 55, 45, 64, 54, 44, 34, 35, 36, 37, 47, 57, 67, 28, 38, 48, 58, 68, 78, 77, 76, 75, 74,
                        73, 63, 53, 43, 33, 23, 82, 72, 62, 52, 42, 32, 22, 12, 13, 14, 15, 16, 17, 18, 19, 29, 39, 49,
                        59, 69, 79, 89, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81,
                        71, 61, 51, 41, 31, 21, 11, 1
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴38 : TriggerState {
            internal State퍼즐패턴38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {45, 34, 23, 12, 1}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {46, 37, 28, 19, 10}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {56, 67, 78, 89, 100}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {55, 64, 73, 82, 91}, arg2: false, arg3: 0, arg4: 200);
                context.SetMesh(arg1: new[] {44, 33, 22, 11}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {35, 24, 13, 2}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {36, 27, 18, 9}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {47, 38, 29, 20}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {57, 68, 79, 90}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {66, 77, 88, 99}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {65, 74, 83, 92}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {54, 63, 72, 81}, arg2: false, arg3: 1300, arg4: 200);
                context.SetMesh(arg1: new[] {43, 32, 21}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {25, 14, 3}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {26, 17, 8}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {48, 39, 30}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {58, 69, 80}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {76, 87, 98}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {75, 84, 93}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {53, 62, 71}, arg2: false, arg3: 2400, arg4: 200);
                context.SetMesh(arg1: new[] {42, 31}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {15, 4}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {16, 7}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {49, 40}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {59, 70}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {86, 97}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {85, 94}, arg2: false, arg3: 3500, arg4: 200);
                context.SetMesh(arg1: new[] {52, 61}, arg2: false, arg3: 3500, arg4: 200);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴39 : TriggerState {
            internal State퍼즐패턴39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {45}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {35, 25, 15, 5}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 41}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {46}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {36, 26, 16, 6}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {47, 48, 49, 50}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {56}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {57, 58, 59, 60}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {66, 76, 86, 96}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {65, 75, 85, 95}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {54, 53, 52, 51}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {34}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {33, 32, 31}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {24, 14, 4}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {38, 39, 40}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {27, 17, 7}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {67}, arg2: false, arg3: 900, arg4: 0);
                context.SetMesh(arg1: new[] {77, 87, 97}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {68, 69, 70}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {23}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {22, 21}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {13, 3}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {18, 8}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {29, 30}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {78}, arg2: false, arg3: 1700, arg4: 0);
                context.SetMesh(arg1: new[] {79, 80}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {88, 98}, arg2: false, arg3: 1800, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {81}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {92}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {12}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {11}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {2}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {20}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {9}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {89}, arg2: false, arg3: 2400, arg4: 0);
                context.SetMesh(arg1: new[] {99}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {90}, arg2: false, arg3: 2500, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴40 : TriggerState {
            internal State퍼즐패턴40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0,
                    arg4: 100);
                context.SetMesh(arg1: new[] {9, 18, 27, 36, 45, 54, 63, 72, 81, 20, 29, 38, 47, 56, 65, 74, 83, 92},
                    arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {8, 17, 26, 35, 44, 53, 62, 71, 30, 39, 48, 57, 66, 75, 84, 93},
                    arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {7, 16, 25, 34, 43, 52, 61, 40, 49, 58, 67, 76, 85, 94}, arg2: false,
                    arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {6, 15, 24, 33, 42, 51, 50, 59, 68, 77, 86, 95}, arg2: false,
                    arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {5, 14, 23, 32, 41, 60, 69, 78, 87, 96}, arg2: false, arg3: 2500,
                    arg4: 0);
                context.SetMesh(arg1: new[] {4, 13, 22, 31, 70, 79, 88, 97}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 12, 21, 80, 89, 98}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 11, 90, 99}, arg2: false, arg3: 4000, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴41 : TriggerState {
            internal State퍼즐패턴41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0,
                    arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        81, 71, 61, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 18, 27, 36, 45, 54, 63, 72, 62, 52,
                        42, 32, 22, 12, 13, 14, 15, 16, 17, 26, 35, 44, 53, 43, 33, 23
                    }, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        92, 93, 94, 95, 96, 97, 98, 99, 100, 90, 80, 70, 60, 50, 40, 30, 20, 29, 38, 47, 56, 65, 74, 83,
                        84, 85, 86, 87, 88, 89, 79, 69, 59, 49, 39, 48, 57, 66, 75, 76, 77, 78
                    }, arg2: false, arg3: 1000, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴42 : TriggerState {
            internal State퍼즐패턴42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10, 19, 28, 37, 46, 55, 64, 73, 82, 91}, arg2: false, arg3: 0,
                    arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        81, 71, 61, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 7, 8, 9, 20, 30, 40, 50, 60, 70, 80, 90, 100,
                        99, 98, 97, 96, 95, 94, 93, 92, 72, 62, 52, 42, 32, 22, 12, 13, 14, 15, 16, 17, 18, 29, 39, 49,
                        59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 63, 53, 43, 33, 23, 24, 25, 26, 27, 38, 48, 58, 68, 78,
                        77, 76, 75, 74, 54, 44, 34, 35, 36, 47, 57, 67, 66, 65
                    }, arg2: false, arg3: 1000, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴43 : TriggerState {
            internal State퍼즐패턴43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 100, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 600, arg4: 100);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 900, arg4: 100);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1200, arg4: 100);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {6, 17, 28, 39, 50}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(arg1: new[] {51, 62, 73, 84, 95}, arg2: false, arg3: 2500, arg4: 100);
                context.SetMesh(arg1: new[] {5, 16, 27, 38, 49, 60}, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {41, 52, 63, 74, 85, 96}, arg2: false, arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 48, 59, 70}, arg2: false, arg3: 4200, arg4: 100);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75, 86, 97}, arg2: false, arg3: 4900, arg4: 100);
                context.SetMesh(arg1: new[] {3, 14, 25, 36, 47, 58, 69, 80}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(arg1: new[] {21, 32, 43, 54, 65, 76, 87, 98}, arg2: false, arg3: 6400, arg4: 100);
                context.SetMesh(arg1: new[] {2, 13, 24, 35, 46, 57, 68, 79, 90}, arg2: false, arg3: 7200,
                    arg4: 100);
                context.SetMesh(arg1: new[] {11, 22, 33, 44, 55, 66, 77, 88, 99}, arg2: false, arg3: 8100,
                    arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴44 : TriggerState {
            internal State퍼즐패턴44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {20, 30, 40, 50, 60, 70, 80, 90, 100}, arg2: false, arg3: 1000,
                    arg4: 100);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 1900, arg4: 0);
                context.SetMesh(arg1: new[] {81, 71, 61, 51, 41, 31, 21, 11}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(arg1: new[] {92, 93, 94, 95, 96, 97, 98, 99}, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(arg1: new[] {19}, arg2: false, arg3: 3600, arg4: 0);
                context.SetMesh(arg1: new[] {18, 17, 16, 15, 14, 13, 12}, arg2: false, arg3: 3700, arg4: 100);
                context.SetMesh(arg1: new[] {29, 39, 49, 59, 69, 79, 89}, arg2: false, arg3: 4400, arg4: 100);
                context.SetMesh(arg1: new[] {82}, arg2: false, arg3: 5100, arg4: 0);
                context.SetMesh(arg1: new[] {72, 62, 52, 42, 32, 22}, arg2: false, arg3: 5200, arg4: 100);
                context.SetMesh(arg1: new[] {83, 84, 85, 86, 87, 88}, arg2: false, arg3: 5800, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 6400, arg4: 0);
                context.SetMesh(arg1: new[] {27, 26, 25, 24, 23}, arg2: false, arg3: 6500, arg4: 100);
                context.SetMesh(arg1: new[] {38, 48, 58, 68, 78}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 7500, arg4: 0);
                context.SetMesh(arg1: new[] {63, 53, 43, 33}, arg2: false, arg3: 7600, arg4: 100);
                context.SetMesh(arg1: new[] {74, 75, 76, 77}, arg2: false, arg3: 8000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 8400, arg4: 0);
                context.SetMesh(arg1: new[] {36, 35, 34}, arg2: false, arg3: 8500, arg4: 100);
                context.SetMesh(arg1: new[] {47, 57, 67}, arg2: false, arg3: 8800, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 9100, arg4: 0);
                context.SetMesh(arg1: new[] {54, 44}, arg2: false, arg3: 9200, arg4: 100);
                context.SetMesh(arg1: new[] {65, 66}, arg2: false, arg3: 9400, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴45 : TriggerState {
            internal State퍼즐패턴45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27}, arg2: false, arg3: 800, arg4: 100);
                context.SetMesh(arg1: new[] {64, 63, 73, 74}, arg2: false, arg3: 1200, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, arg2: false, arg3: 2000, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61, 51, 41, 31,
                        21, 11
                    }, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {12, 13, 14, 15, 16, 17, 18, 19}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(
                    arg1: new[] {29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 62, 52, 42, 32, 22},
                    arg2: false, arg3: 6400, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴46 : TriggerState {
            internal State퍼즐패턴46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false,
                    arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {67, 77, 78, 68, 58, 57, 56, 66, 76, 86, 87, 88, 89, 79, 69, 59},
                    arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 26, 36, 46, 47, 48, 49, 39, 29, 19, 18, 17, 16},
                    arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {64, 63, 73, 74, 75, 65, 55, 54, 53, 52, 62, 72, 82, 83, 84, 85},
                    arg2: false, arg3: 4800, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴47 : TriggerState {
            internal State퍼즐패턴47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false,
                    arg3: 400, arg4: 100);
                context.SetMesh(
                    arg1: new[] {55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 56},
                    arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false,
                    arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {90, 80, 70, 60, 50, 40, 30, 20, 10, 9, 8, 7}, arg2: false, arg3: 4900,
                    arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        17, 27, 37, 47, 57, 67, 77, 87, 88, 89, 79, 69, 59, 49, 39, 29, 19, 18, 28, 38, 48, 58, 68, 78,
                        88
                    }, arg2: false, arg3: 6100, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴48 : TriggerState {
            internal State퍼즐패턴48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {33, 23, 24, 34}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 45}, arg2: false,
                    arg3: 400, arg4: 100);
                context.SetMesh(
                    arg1: new[] {55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 56},
                    arg2: false, arg3: 1600, arg4: 100);
                context.SetMesh(arg1: new[] {61, 71, 81, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100}, arg2: false,
                    arg3: 3600, arg4: 100);
                context.SetMesh(arg1: new[] {90, 80, 70, 60, 50, 40, 30, 20, 10}, arg2: false, arg3: 4900,
                    arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        9, 19, 29, 39, 49, 59, 69, 79, 89, 88, 87, 86, 85, 84, 83, 82, 72, 73, 74, 75, 76, 77, 78, 68,
                        67, 66, 65, 64, 63, 62
                    }, arg2: false, arg3: 5800, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴49 : TriggerState {
            internal State퍼즐패턴49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        45, 44, 43, 42, 32, 22, 12, 13, 14, 15, 25, 35, 56, 57, 58, 59, 69, 79, 89, 88, 87, 86, 76, 66
                    }, arg2: false, arg3: 800, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        55, 54, 53, 52, 51, 41, 31, 21, 11, 1, 2, 3, 4, 5, 6, 16, 26, 36, 46, 47, 48, 49, 50, 60, 70,
                        80, 90, 100, 99, 98, 97, 96, 95, 85, 75, 65
                    }, arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {64}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {37}, arg2: false, arg3: 7000, arg4: 100);
                context.SetMesh(arg1: new[] {63, 62, 61}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {74, 84, 94}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {27, 17, 7}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {38, 39, 40}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {28}, arg2: false, arg3: 7700, arg4: 100);
                context.SetMesh(arg1: new[] {73}, arg2: false, arg3: 7700, arg4: 100);
                context.SetMesh(arg1: new[] {18, 8}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {29, 30}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {72, 71}, arg2: false, arg3: 8200, arg4: 100);
                context.SetMesh(arg1: new[] {83, 93}, arg2: false, arg3: 8200, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴50 : TriggerState {
            internal State퍼즐패턴50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 64, 63, 73, 74}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {82, 81, 91, 92, 19, 20, 10, 9}, arg2: false, arg3: 2100, arg4: 100);
                context.SetMesh(arg1: new[] {12, 11, 1, 2, 89, 90, 99, 100}, arg2: false, arg3: 3200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 5, 6, 16, 86, 96, 85, 95}, arg2: false, arg3: 4300, arg4: 100);
                context.SetMesh(arg1: new[] {42, 41, 51, 52, 59, 60, 50, 49}, arg2: false, arg3: 5400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 6500, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴51 : TriggerState {
            internal State퍼즐패턴51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {34, 33, 23, 24}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {77, 78, 68, 67}, arg2: false, arg3: 400, arg4: 100);
                context.SetMesh(arg1: new[] {37, 38, 28, 27, 64, 63, 73, 74}, arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(arg1: new[] {82, 83, 93, 92, 91, 81, 71, 72, 19, 18, 8, 9, 10, 20, 30, 29},
                    arg2: false, arg3: 2100, arg4: 100);
                context.SetMesh(arg1: new[] {12, 22, 21, 11, 1, 2, 3, 13, 89, 79, 80, 90, 100, 99, 98, 88},
                    arg2: false, arg3: 3700, arg4: 100);
                context.SetMesh(arg1: new[] {15, 5, 6, 16, 86, 96, 85, 95}, arg2: false, arg3: 5300, arg4: 100);
                context.SetMesh(arg1: new[] {42, 41, 51, 52, 59, 60, 50, 49}, arg2: false, arg3: 6400, arg4: 100);
                context.SetMesh(arg1: new[] {55, 45, 46, 56}, arg2: false, arg3: 7500, arg4: 100);
                context.SetMesh(arg1: new[] {66, 65, 54, 44, 35, 36, 47, 57}, arg2: false, arg3: 8100, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴52 : TriggerState {
            internal State퍼즐패턴52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6}, arg2: false, arg3: 500, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37},
                    arg2: false, arg3: 1400, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        68, 58, 59, 69, 79, 78, 77, 67, 57, 47, 48, 49, 50, 60, 70, 80, 90, 89, 88, 87, 86, 76, 66, 56,
                        46
                    }, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {73, 74, 84, 83, 82, 72, 62, 63, 64, 65, 75, 85, 95, 94, 93, 92},
                    arg2: false, arg3: 5500, arg4: 100);
                context.SetMesh(arg1: new[] {42, 43, 53, 52, 51, 41, 31, 32, 33}, arg2: false, arg3: 7100,
                    arg4: 100);
                context.SetMesh(arg1: new[] {44, 34, 35, 45}, arg2: false, arg3: 8000, arg4: 100);
                context.SetMesh(arg1: new[] {55}, arg2: false, arg3: 8400, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴53 : TriggerState {
            internal State퍼즐패턴53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3}, arg2: false, arg3: 100, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6}, arg2: false, arg3: 500, arg4: 100);
                context.SetMesh(arg1: new[] {18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37},
                    arg2: false, arg3: 1400, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        68, 58, 59, 69, 79, 78, 77, 67, 57, 47, 48, 49, 50, 60, 70, 80, 90, 89, 88, 87, 86, 76, 66, 56,
                        46
                    }, arg2: false, arg3: 3000, arg4: 100);
                context.SetMesh(arg1: new[] {96}, arg2: false, arg3: 5500, arg4: 100);
                context.SetMesh(arg1: new[] {95, 94, 84, 85}, arg2: false, arg3: 5600, arg4: 100);
                context.SetMesh(arg1: new[] {82, 83, 93, 92, 91, 81, 71, 72, 73}, arg2: false, arg3: 6000,
                    arg4: 100);
                context.SetMesh(arg1: new[] {52, 42, 43, 53, 63, 62, 61, 51, 41, 31, 32, 33, 34, 44, 54, 64},
                    arg2: false, arg3: 6900, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴54 : TriggerState {
            internal State퍼즐패턴54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 100}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3, 88, 89, 99, 98}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6, 86, 85, 75, 76, 77, 87, 97, 96, 95},
                    arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37, 83, 82, 72, 73, 74, 84, 94, 93, 92,
                        91, 81, 71, 61, 62, 63, 64
                    }, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(arg1: new[] {50, 51}, arg2: false, arg3: 6000, arg4: 100);
                context.SetMesh(arg1: new[] {60, 70, 69, 59, 41, 31, 32, 42}, arg2: false, arg3: 6200, arg4: 100);
                context.SetMesh(
                    arg1: new[] {57, 58, 68, 67, 66, 56, 46, 47, 48, 44, 43, 33, 34, 35, 45, 55, 54, 53},
                    arg2: false, arg3: 7000, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴55 : TriggerState {
            internal State퍼즐패턴55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {1, 100}, arg2: false, arg3: 0, arg4: 100);
                context.SetMesh(arg1: new[] {13, 12, 2, 3, 88, 89, 99, 98}, arg2: false, arg3: 200, arg4: 100);
                context.SetMesh(arg1: new[] {15, 16, 26, 25, 24, 14, 4, 5, 6, 86, 85, 75, 76, 77, 87, 97, 96, 95},
                    arg2: false, arg3: 1000, arg4: 100);
                context.SetMesh(
                    arg1: new[] {
                        18, 19, 29, 28, 27, 17, 7, 8, 9, 10, 20, 30, 40, 39, 38, 37, 83, 82, 72, 73, 74, 84, 94, 93, 92,
                        91, 81, 71, 61, 62, 63, 64
                    }, arg2: false, arg3: 2800, arg4: 100);
                context.SetMesh(
                    arg1: new[] {59, 60, 70, 69, 68, 58, 48, 49, 50, 42, 41, 31, 32, 33, 43, 53, 52, 51},
                    arg2: false, arg3: 6000, arg4: 100);
                context.SetMesh(arg1: new[] {56, 57, 67, 66, 45, 44, 34, 35}, arg2: false, arg3: 7800, arg4: 100);
                context.SetMesh(arg1: new[] {46, 55}, arg2: false, arg3: 8600, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴56 : TriggerState {
            internal State퍼즐패턴56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93,
                        92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 19, 29, 69, 79, 89, 88, 87,
                        84, 83, 82, 72, 62, 22, 25, 26, 38, 48, 58, 78, 76, 75, 73, 53, 43, 33, 34, 37, 47, 57, 67, 66,
                        65, 64, 54, 44, 45, 46, 56, 55
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴57 : TriggerState {
            internal State퍼즐패턴57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 8, 9, 10, 20, 30, 40, 50, 90, 100, 99, 92, 91, 81, 41, 31, 21, 11, 12, 13, 14,
                        17, 18, 19, 29, 39, 59, 69, 79, 88, 87, 86, 85, 84, 83, 72, 62, 52, 32, 22, 23, 26, 27, 28, 48,
                        58, 68, 78, 77, 74, 73, 63, 53, 43, 34, 35, 47, 67, 66, 65, 64, 44, 45, 46, 56, 55
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴58 : TriggerState {
            internal State퍼즐패턴58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 99, 98, 97, 96, 95, 94, 93,
                        92, 91, 81, 71, 61, 51, 41, 31, 21, 11, 12, 13, 14, 15, 16, 17, 18, 29, 39, 49, 59, 69, 79, 89,
                        88, 87, 86, 85, 84, 83, 72, 62, 52, 42, 32, 22, 23, 25, 26, 48, 58, 78, 77, 76, 75, 53, 43, 33,
                        34, 37, 67, 66, 64, 44, 46, 55
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴59 : TriggerState {
            internal State퍼즐패턴59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 6, 7, 8, 9, 10, 20, 30, 40, 50, 90, 100, 99, 98, 97, 96, 95, 94, 93, 92, 91, 81, 71, 61,
                        51, 41, 31, 21, 11, 13, 14, 15, 17, 18, 19, 29, 39, 59, 69, 79, 78, 77, 76, 75, 74, 73, 23, 24,
                        25, 27, 28, 38, 58, 68, 67, 66, 65, 64, 63, 53, 43, 33, 34, 35, 37, 57, 67, 66, 65, 64, 54, 44,
                        45, 56, 55
                    }, arg2: false, arg3: 0, arg4: 100);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State퍼즐패턴60 : TriggerState {
            internal State퍼즐패턴60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 14);
                context.SetMesh(arg1: new[] {10}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {9, 20}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {8, 19, 30}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {7, 18, 29, 40}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {28, 39, 50}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {5, 16, 49, 60}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {4, 15, 26, 37, 59, 70}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {3, 14, 25, 47, 69, 80}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {2, 13, 24, 46, 57, 90}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {1, 12, 23, 34, 45, 56, 78, 100}, arg2: false, arg3: 4500, arg4: 0);
                context.SetMesh(arg1: new[] {11, 22, 55, 66, 77, 88, 99}, arg2: false, arg3: 4000, arg4: 0);
                context.SetMesh(arg1: new[] {21, 43, 65, 87}, arg2: false, arg3: 3500, arg4: 0);
                context.SetMesh(arg1: new[] {31, 42, 53, 64, 75}, arg2: false, arg3: 3000, arg4: 0);
                context.SetMesh(arg1: new[] {52, 74, 85, 96}, arg2: false, arg3: 2500, arg4: 0);
                context.SetMesh(arg1: new[] {73, 84, 95}, arg2: false, arg3: 2000, arg4: 0);
                context.SetMesh(arg1: new[] {61, 72, 83, 94}, arg2: false, arg3: 1500, arg4: 0);
                context.SetMesh(arg1: new[] {71, 82, 93}, arg2: false, arg3: 1000, arg4: 0);
                context.SetMesh(arg1: new[] {81, 92}, arg2: false, arg3: 500, arg4: 0);
                context.SetMesh(arg1: new[] {91}, arg2: false, arg3: 0, arg4: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State실패계단보이기 : TriggerState {
            internal State실패계단보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EndMiniGameRound(winnerBoxId: 301);
                context.EndMiniGame(winnerBoxId: 301, gameName: "trapmaster");
                context.UnSetMiniGameAreaForHack();
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.PlaySystemSoundInBox(arg1: new[] {301}, arg2: "ME_001_Massive00_14");
                context.SetEventUI(arg1: 5, arg2: "$61000001_ME_001__MASSIVE00__14$", arg3: 5000);
                context.SetMesh(
                    arg1: new[] {
                        1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26,
                        27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50,
                        51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
                        75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98,
                        99, 100
                    }, arg2: true);
                context.SetPortal(arg1: 777, arg2: false, arg3: true, arg4: true);
                context.SetMesh(arg1: new[] {201, 202, 203, 204, 205}, arg2: true);
                context.SetActor(arg1: 251, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 252, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 253, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 254, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 255, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State실패계단보이기2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State실패계단보이기2 : TriggerState {
            internal State실패계단보이기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetMesh(arg1: new[] {206, 207, 208, 209, 210}, arg2: true);
                context.SetActor(arg1: 256, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 257, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 258, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 259, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
                context.SetActor(arg1: 260, arg2: true, arg3: "Eff_MassiveEvent_Stair_Opened");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "1");
            }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {211}, arg2: true);
                context.SetActor(arg1: 261, arg2: true, arg3: "Eff_MassiveEvent_Door_Opened");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State실패2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패2 : TriggerState {
            internal State실패2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State유저이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000007_ME__MAINPROCESS_SPRINGBEACH__23$", arg3: 5000,
                    arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    context.MoveUser(arg1: 0, arg2: 0);
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