namespace Maple2.Trigger._52000150_qd {
    public static class _contents_trigger {
        public class State차원의숲전경씬종료 : TriggerState {
            internal State차원의숲전경씬종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "52000150") == 1) {
                    context.State = new State웨이브1알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브1알림 : TriggerState {
            internal State웨이브1알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {10010}, arg2: new[] {50001641}, arg3: new byte[] {2})) {
                    context.State = new State컨텐츠종료01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브1생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브1생성 : TriggerState {
            internal State웨이브1생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {400, 401, 402, 403, 404})) {
                    context.State = new State웨이브2알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브2알림 : TriggerState {
            internal State웨이브2알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브2생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브2생성 : TriggerState {
            internal State웨이브2생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {500, 501, 502, 503, 504}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {500, 501, 502, 503, 504})) {
                    context.State = new State웨이브3알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브3알림 : TriggerState {
            internal State웨이브3알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브3생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브3생성 : TriggerState {
            internal State웨이브3생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {600, 601, 602, 603, 604}, arg2: false);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {600, 601, 602, 603, 604})) {
                    context.State = new State웨이브4알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브4알림 : TriggerState {
            internal State웨이브4알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브4생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브4생성 : TriggerState {
            internal State웨이브4생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {300, 301, 302, 303, 304}, arg2: false);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {300, 301, 302, 303, 304})) {
                    context.State = new State웨이브5알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브5알림 : TriggerState {
            internal State웨이브5알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브5생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브5생성 : TriggerState {
            internal State웨이브5생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {600, 601, 602, 603, 604, 400, 401, 402, 403, 404}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {600, 601, 602, 603, 604, 400, 401, 402, 403, 404})) {
                    context.State = new State웨이브6알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브6알림 : TriggerState {
            internal State웨이브6알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브6생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브6생성 : TriggerState {
            internal State웨이브6생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {500, 501, 502, 503, 504, 300, 301, 302, 303, 304}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {300, 301, 302, 303, 304, 500, 501, 502, 503, 504})) {
                    context.State = new State웨이브7알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브7알림 : TriggerState {
            internal State웨이브7알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {2300, 2301, 2302, 2303, 2304}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2400, 2401, 2402, 2403, 2404}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2500, 2501, 2502, 2503, 2504}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2600, 2601, 2602, 2603, 2604}, arg2: true, arg3: 0, arg4: 200);
                context.SetEffect(arg1: new[] {2606}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State웨이브7생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State웨이브7생성 : TriggerState {
            internal State웨이브7생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {300, 301, 302, 303, 304, 400, 401, 402, 403, 404, 500, 501, 502, 503, 504, 600, 601, 602, 603, 604}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {300, 301, 302, 303, 304, 400, 401, 402, 403, 404, 500, 501, 502, 503, 504, 600, 601, 602, 603, 604})) {
                    context.State = new State컨텐츠종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State컨텐츠종료01 : TriggerState {
            internal State컨텐츠종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {300, 301, 302, 303, 304, 400, 401, 402, 403, 404, 500, 501, 502, 503, 504, 600, 601, 602, 603, 604});
                context.SetProductionUI(arg1: 1);
                context.SetTimeScale(enable: true, startScale: 0.1f, endScale: 0.5f, duration: 10.0f, interpolator: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State컨텐츠종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State컨텐츠종료02 : TriggerState {
            internal State컨텐츠종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetEffect(arg1: new[] {2607}, arg2: false);
                context.DestroyMonster(arg1: new[] {700});
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_caitMove01");
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Bore_A");
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Event_01_A", arg3: 999999f);
                context.SetUserValue(triggerId: 10000, key: "52000150monster", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State컨텐츠종료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State컨텐츠종료03 : TriggerState {
            internal State컨텐츠종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 20, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetUserValue(triggerId: 10000, key: "52000150monster", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}