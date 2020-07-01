using System.Numerics;

namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_main {
        public class StateReception : TriggerState {
            internal StateReception(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10001, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10002, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.SetEffect(arg1: new[] {3000}, arg2: false);
                context.SetEffect(arg1: new[] {3001}, arg2: false);
                context.SetEffect(arg1: new[] {3002}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateEntryDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEntryDelay : TriggerState {
            internal StateEntryDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 40, arg3: true, arg4: false);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Stateopeningscene_start(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9000) == 70) {
                    context.State = new Stateopeningscene_start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_start : TriggerState {
            internal Stateopeningscene_start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
                context.CameraSelectPath(arg1: new[] {5004, 5003}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateopeningscene_1_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_1_1 : TriggerState {
            internal Stateopeningscene_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__0$", duration: 3000,
                    delayTick: 500);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__1$", duration: 3000,
                    delayTick: 3500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new Stateopeningscene_1_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateopeningscene_1_2 : TriggerState {
            internal Stateopeningscene_1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {3001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__2$", duration: 3000,
                    delayTick: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new Stateopeningscene_1_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {101});
            }
        }

        private class Stateopeningscene_1_3 : TriggerState {
            internal Stateopeningscene_1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(150f, 150f, 150f));
                context.CreateMonster(arg1: new[] {201}, arg2: false, arg3: 30000);
                context.SetEffect(arg1: new[] {3002}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 201, msg: "$84000006_WD__84000006_WD_MAIN__3$", duration: 4000,
                    delayTick: 1000);
                context.AddBalloonTalk(spawnPointId: 201, msg: "$84000006_WD__84000006_WD_MAIN__4$", duration: 4000,
                    delayTick: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateGameGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide01 : TriggerState {
            internal StateGameGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1.0f);
                context.AddBuff(arg1: new[] {9002}, arg2: 99940044, arg3: 1, arg4: false, arg5: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.VisibleMyPc(isVisible: true);
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__5$");
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 20000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide02 : TriggerState {
            internal StateGameGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__6$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameGuide03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide03 : TriggerState {
            internal StateGameGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__7$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameGuide04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide04 : TriggerState {
            internal StateGameGuide04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__8$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameGuide05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide05 : TriggerState {
            internal StateGameGuide05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__9$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameGuide06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameGuide06 : TriggerState {
            internal StateGameGuide06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 2, arg2: "$84000006_WD__84000006_WD_MAIN__10$", arg3: 3000,
                    arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePinata_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Ready : TriggerState {
            internal StatePinata_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 1);
                context.DestroyMonster(arg1: new[] {102});
                context.SetMesh(
                    arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.StartMiniGame(boxId: 9001, round: 1, isShowResultUI: "False", gameName: "PinataWD");
                context.AddBalloonTalk(spawnPointId: 201, msg: "$84000006_WD__84000006_WD_MAIN__11$", duration: 8000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityId: 28500010, textId: 28500010, duration: 5000);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Steal") == 1) {
                    context.State = new StatePinata_Fight(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fight : TriggerState {
            internal StatePinata_Fight(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 11004772, illust: "Conder_normal", duration: 4000,
                    script: "$84000006_WD__84000006_WD_MAIN__12$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePinata_Fight2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fight2 : TriggerState {
            internal StatePinata_Fight2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 60, arg4: true);
                context.SetEventUI(arg1: 1, arg2: "$84000006_WD__84000006_WD_MAIN__13$", arg3: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    context.AddBalloonTalk(spawnPointId: 201, msg: "$84000006_WD__84000006_WD_MAIN__14$",
                        duration: 3000, delayTick: 1000);
                    context.SetTimer(arg1: "4", arg2: 20, arg3: false, arg4: false);
                    context.State = new StatePinata_Kill(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.AddBalloonTalk(spawnPointId: 201, msg: "$84000006_WD__84000006_WD_MAIN__15$",
                        duration: 3000, delayTick: 1000);
                    context.SetTimer(arg1: "4", arg2: 20, arg3: false, arg4: false);
                    context.State = new StatePinata_noKill(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Kill : TriggerState {
            internal StatePinata_Kill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.EndMiniGameRound(winnerBoxId: 9001, expRate: 0.1f);
                context.EndMiniGame(winnerBoxId: 9001, gameName: "PinataWD");
                context.AddBuff(arg1: new[] {9001}, arg2: 70000019, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StatePinata_Revive(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_noKill : TriggerState {
            internal StatePinata_noKill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
                context.EndMiniGameRound(winnerBoxId: 9002, expRate: 0.1f);
                context.EndMiniGame(winnerBoxId: 9002, gameName: "PinataWD");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StatePinata_Revive2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Revive : TriggerState {
            internal StatePinata_Revive(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 2);
                context.SetEventUI(arg1: 3, arg2: "$84000006_WD__84000006_WD_MAIN__16$", arg3: 3000,
                    arg4: "9001");
                context.SetEventUI(arg1: 4, arg2: "$84000006_WD__84000006_WD_MAIN__17$", arg3: 3000,
                    arg4: "!9001");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetEffect(arg1: new[] {3001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__18$", duration: 5000,
                    delayTick: 100);
                context.AddBalloonTalk(spawnPointId: 103, msg: "$84000006_WD__84000006_WD_MAIN__19$", duration: 20000,
                    delayTick: 1000);
                context.SetAmbientLight(arg1: new Vector3(255f, 255f, 255f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StatePinata_Fireworks(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Revive2 : TriggerState {
            internal StatePinata_Revive2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAmbientLight(arg1: new Vector3(255f, 255f, 255f));
                context.SetUserValue(triggerId: 1004, key: "Interaction", value: 2);
                context.SetEventUI(arg1: 3, arg2: "$84000006_WD__84000006_WD_MAIN__20$", arg3: 3000,
                    arg4: "9002");
                context.SetEventUI(arg1: 4, arg2: "$84000006_WD__84000006_WD_MAIN__21$", arg3: 3000,
                    arg4: "!9002");
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
                context.SetEffect(arg1: new[] {3001}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__22$", duration: 5000,
                    delayTick: 100);
                context.AddBalloonTalk(spawnPointId: 103, msg: "$84000006_WD__84000006_WD_MAIN__23$", duration: 20000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StatePinata_Fireworks(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePinata_Fireworks : TriggerState {
            internal StatePinata_Fireworks(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {5002, 5001}, arg2: true);
                context.SetUserValue(triggerId: 1002, key: "Fireworks", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new StateFinale(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFinale : TriggerState {
            internal StateFinale(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8022, 8023, 8024}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(arg1: 10001, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10002, arg2: true, arg3: true, arg4: true);
                context.SetUserValue(triggerId: 1001, key: "Conder", value: 1);
                context.AddBuff(arg1: new[] {9002}, arg2: 99940042, arg3: 1, arg4: false, arg5: true);
                context.SetEventUI(arg1: 1, arg2: "$84000006_WD__84000006_WD_MAIN__24$", arg3: 3000);
                context.SetTimer(arg1: "5", arg2: 150, arg3: false, arg4: true);
                context.AddBalloonTalk(spawnPointId: 101, msg: "$84000006_WD__84000006_WD_MAIN__25$", duration: 5000,
                    delayTick: 3000);
                context.AddBalloonTalk(spawnPointId: 103, msg: "$84000006_WD__84000006_WD_MAIN__26$", duration: 5000,
                    delayTick: 3000);
                context.SetPhotoStudio(isEnable: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateReturn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturn : TriggerState {
            internal StateReturn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.RoomExpire();
                    context.State = new StateEndGame(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEndGame : TriggerState {
            internal StateEndGame(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}