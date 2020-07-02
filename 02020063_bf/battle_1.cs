namespace Maple2.Trigger._02020063_bf {
    public static class _battle_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990001, key: "Battle_1_Clear", value: 0);
                context.StartCombineSpawn(groupId: new[] {500}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {501}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {502}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {503}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {504}, isStart: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 1) {
                    return new State스폰_1_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_SE : TriggerState {
            internal State스폰_1_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.ScoreBoardCreate(type: "ShadowGauge", maxScore: 800);
                context.StartCombineSpawn(groupId: new[] {500}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1 : TriggerState {
            internal State스폰_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.SideNpcTalk(type: "talk", npcId: 11003533, illust: "Bliche_normal", duration: 5000, script: "$02020063_BF__BATTLE_1__0$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1_추가대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가대사1 : TriggerState {
            internal State스폰_1_추가대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11001813, illust: "Turka_normal", duration: 5000, script: "$02020063_BF__BATTLE_1__1$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_1_추가대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_1_추가대사2 : TriggerState {
            internal State스폰_1_추가대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcId: 11003536, illust: "Neirin_surprise", duration: 5000, script: "$02020063_BF__BATTLE_1__2$");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State스폰_2_SE(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2_SE : TriggerState {
            internal State스폰_2_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_2 : TriggerState {
            internal State스폰_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 990, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {501}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1") || context.GetScoreBoardScore() >= 150) {
                    return new State스폰_3_SE(context);
                }

                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3_SE : TriggerState {
            internal State스폰_3_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_3 : TriggerState {
            internal State스폰_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 990, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {502}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2") || context.GetScoreBoardScore() >= 300) {
                    return new State스폰_4_SE(context);
                }

                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4_SE : TriggerState {
            internal State스폰_4_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_4 : TriggerState {
            internal State스폰_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 990, arg3: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {503}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3") || context.GetScoreBoardScore() >= 450) {
                    return new State스폰_5_SE(context);
                }

                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5_SE : TriggerState {
            internal State스폰_5_SE(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new State스폰_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰_5 : TriggerState {
            internal State스폰_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/Sound/Eff_System_Dark_Intro_Chord_01.xml");
                context.StartCombineSpawn(groupId: new[] {504}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.GetScoreBoardScore() >= 800) {
                    return new State포탑페이즈(context);
                }

                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탑페이즈 : TriggerState {
            internal State포탑페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {500}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {501}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {502}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {503}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {504}, isStart: false);
                context.SetUserValue(triggerId: 99990001, key: "Battle_1_Clear", value: 1);
                context.ScoreBoardRemove();
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Battle_1_SpawnStart") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}