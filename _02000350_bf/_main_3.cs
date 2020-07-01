namespace Maple2.Trigger._02000350_bf {
    public static class _main_3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new[] {704}, arg2: false);
                context.SetEffect(arg1: new[] {630, 620, 6301}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_3__0$", arg3: 2000, arg4: "0");
                context.DarkStream(type: "StartRound", round: 11, uiDuration: 3000, damagePenalty: 30);
                context.SetEventUI(arg1: 0, arg2: "11,15,11");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State11라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11라운드 : TriggerState {
            internal State11라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000350_BF__MAIN_3__1$", arg3: 4000, arg4: "0");
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {111001}, score: 295000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {111001})) {
                    context.DarkStream(type: "ClearRound", round: 11);
                    context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "11roundpass");
                    context.State = new State12라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12라운드대기 : TriggerState {
            internal State12라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "12,15,11");
                context.DarkStream(type: "StartRound", round: 12, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State12라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12라운드 : TriggerState {
            internal State12라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {112001}, score: 78750);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {112001})) {
                    context.DarkStream(type: "ClearRound", round: 12);
                    context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "12roundpass");
                    context.State = new State13라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State13라운드대기 : TriggerState {
            internal State13라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "13,15,11");
                context.SetTimer(arg1: "3", arg2: 3);
                context.DarkStream(type: "StartRound", round: 13, uiDuration: 3000, damagePenalty: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State13라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State13라운드 : TriggerState {
            internal State13라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {113001}, score: 43750);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {113001})) {
                    context.DarkStream(type: "ClearRound", round: 13);
                    context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "13roundpass");
                    context.State = new State14라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State14라운드대기 : TriggerState {
            internal State14라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "14,15,11");
                context.DarkStream(type: "StartRound", round: 14, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State14라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State14라운드 : TriggerState {
            internal State14라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {114001}, score: 48750);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {114001})) {
                    context.DarkStream(type: "ClearRound", round: 14);
                    context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "14roundpass");
                    context.State = new State15라운드대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State15라운드대기 : TriggerState {
            internal State15라운드대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "15,15,11");
                context.SetEffect(arg1: new[] {6301}, arg2: true);
                context.DarkStream(type: "StartRound", round: 15, uiDuration: 3000, damagePenalty: 30);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State15라운드(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State15라운드 : TriggerState {
            internal State15라운드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DarkStream(type: "SpawnMonster", spawnId: new[] {115001}, score: 415000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {115001})) {
                    context.DarkStream(type: "ClearRound", round: 15);
                    context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "15roundpass");
                    context.State = new State바닥부심(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥부심 : TriggerState {
            internal State바닥부심(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetEffect(arg1: new[] {630}, arg2: true);
                    context.SetSkill(arg1: new[] {704}, arg2: true);
                    context.SetMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323, 3324, 3325, 3326, 3327, 3328, 3329, 3330, 3331, 3332, 3333, 3334, 3335, 3336, 3337, 3338, 3339, 3340, 3341, 3342, 3343, 3344}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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