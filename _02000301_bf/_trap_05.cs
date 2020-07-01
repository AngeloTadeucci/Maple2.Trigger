namespace Maple2.Trigger._02000301_bf {
    public static class _trap_05 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 210, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_Off");
                context.SetInteractObject(arg1: new[] {10000513}, arg2: 1);
                context.SetEffect(arg1: new[] {606}, arg2: false);
                context.SetEffect(arg1: new[] {604}, arg2: false);
                context.SetEffect(arg1: new[] {610}, arg2: false);
                context.SetMesh(arg1: new[] {3051, 3052, 3053, 3054, 3055, 3056}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516,
                        4517, 4518, 4519
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10501})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10502})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10503})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10504})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {10505})) {
                    context.State = new State경보(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000513}, arg2: 0)) {
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경보 : TriggerState {
            internal State경보(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 210, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_On");
                context.SetInteractObject(arg1: new[] {10000513}, arg2: 0);
                context.CreateMonster(arg1: new[] {2006}, arg2: false);
                context.SetEffect(arg1: new[] {606}, arg2: true);
                context.SetEffect(arg1: new[] {604}, arg2: true);
                context.SetEffect(arg1: new[] {610}, arg2: true);
                context.ShowGuideSummary(entityId: 20003001, textId: 20003001);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetMesh(arg1: new[] {3051, 3052, 3053, 3054, 3055, 3056}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516,
                        4517, 4518, 4519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2006})) {
                    context.HideGuideSummary(entityId: 20003001);
                    context.SetEffect(arg1: new[] {610}, arg2: false);
                    context.SetActor(arg1: 210, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.SetActor(arg1: 211, arg2: true, arg3: "sf_quest_light_A01_Off");
                    context.State = new State해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2006});
                context.SetMesh(arg1: new[] {3051, 3052, 3053, 3054, 3055, 3056}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetMesh(
                    arg1: new[] {
                        4501, 4502, 4503, 4504, 4505, 4506, 4507, 4508, 4509, 4510, 4511, 4512, 4513, 4514, 4515, 4516,
                        4517, 4518, 4519
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}