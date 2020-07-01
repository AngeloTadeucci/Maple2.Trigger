using System;

namespace Maple2.Trigger._52000167_qd {
    public static class _52000167 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1000, arg2: false, arg3: false, arg4: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State묘지전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State묘지전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬01 : TriggerState {
            internal State묘지전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetEffect(arg1: new int[] {700}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State묘지전경씬02_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02_1 : TriggerState {
            internal State묘지전경씬02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_pc");
                context.CameraSelectPath(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State묘지전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬02 : TriggerState {
            internal State묘지전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000167_QD__52000167__0$",
                    desc: "$52000167_QD__52000167__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State묘지전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State묘지전경씬03 : TriggerState {
            internal State묘지전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000167_QD__52000167__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 52001671, textID: 52001671, duration: 10000);
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002369},
                    arg3: new byte[] {3})) {
                    context.State = new State홀슈타트등장00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장00 : TriggerState {
            internal State홀슈타트등장00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
                context.CreateMonster(arg1: new int[] {402}, arg2: false);
                context.CreateMonster(arg1: new int[] {403}, arg2: false);
                context.CreateMonster(arg1: new int[] {404}, arg2: false);
                context.CreateMonster(arg1: new int[] {405}, arg2: false);
                context.CreateMonster(arg1: new int[] {406}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State홀슈타트등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장01 : TriggerState {
            internal State홀슈타트등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {5000, 5001, 5002, 5003, 5004}, arg2: false);
                context.MoveNpc(arg1: 402, arg2: "MS2PatrolData_402_hol");
                context.MoveNpc(arg1: 403, arg2: "MS2PatrolData_403");
                context.MoveNpc(arg1: 404, arg2: "MS2PatrolData_404");
                context.MoveNpc(arg1: 405, arg2: "MS2PatrolData_405");
                context.MoveNpc(arg1: 406, arg2: "MS2PatrolData_406");
                context.MoveUserPath(arg1: "MS2PatrolData_pc_move");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State홀슈타트등장02_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장02_c : TriggerState {
            internal State홀슈타트등장02_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {700}, arg2: true);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.3f, duration: 3.5f, interpolator: 2);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000167_QD__52000167__3$", duration: 6000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State홀슈타트등장02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장02 : TriggerState {
            internal State홀슈타트등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 40, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State홀슈타트등장03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장03 : TriggerState {
            internal State홀슈타트등장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 52001672, textID: 52001672, duration: 10000);
                context.SetOnetimeEffect(id: 40, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002370},
                    arg3: new byte[] {3})) {
                    context.State = new State홀슈타트등장04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State홀슈타트등장04 : TriggerState {
            internal State홀슈타트등장04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 402, arg2: "Attack_Idle_A", arg3: 800000f);
                context.SetNpcEmotionLoop(arg1: 403, arg2: "Attack_Idle_A", arg3: 800000f);
                context.SetNpcEmotionLoop(arg1: 404, arg2: "Attack_Idle_A", arg3: 800000f);
                context.SetNpcEmotionLoop(arg1: 405, arg2: "Attack_Idle_A", arg3: 800000f);
                context.SetNpcEmotionLoop(arg1: 406, arg2: "Attack_Idle_A", arg3: 800000f);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002371},
                    arg3: new byte[] {3})) {
                    context.State = new State수련장이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수련장이동01 : TriggerState {
            internal State수련장이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 100000f, arg3: true);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State수련장이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수련장이동02 : TriggerState {
            internal State수련장이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000168, arg2: 80);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}