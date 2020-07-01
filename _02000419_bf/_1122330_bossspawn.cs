namespace Maple2.Trigger._02000419_bf {
    public static class _1122330_bossspawn {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State몬스터등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2000}, arg2: false);
                context.SetMesh(
                    arg1: new[]
                        {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015},
                    arg2: false, arg3: 0, arg4: 200, arg5: 0.5f);
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: true);
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025
                    }, arg2: false, arg3: 0, arg4: 200, arg5: 0.5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "NextMove") == 1) {
                    context.State = new State두번째전투판이동다리생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {2000})) {
                    context.State = new State연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째전투판이동다리생성 : TriggerState {
            internal State두번째전투판이동다리생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[]
                        {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015},
                    arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
                context.SetMesh(arg1: new[] {5001, 5002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2000})) {
                    context.State = new State연출딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출딜레이 : TriggerState {
            internal State연출딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025
                    }, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetMesh(
                    arg1: new[]
                        {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[]
                        {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015},
                    arg2: true, arg3: 1, arg4: 120, arg5: 0.5f);
                context.SetMesh(arg1: new[] {5001, 5002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DungeonClear();
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}