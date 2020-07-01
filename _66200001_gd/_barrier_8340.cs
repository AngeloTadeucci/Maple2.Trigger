namespace Maple2.Trigger._66200001_gd {
    public static class _barrier_8340 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Barrier34") == 1) {
                    context.State = new StateSensor7341(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7341 : TriggerState {
            internal StateSensor7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 1) {
                    context.State = new StateActivate7341(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7341 : TriggerState {
            internal StateActivate7341(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 1) {
                    context.State = new StateSensor7341(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7342 : TriggerState {
            internal StateSensor7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 2) {
                    context.State = new StateSafeGreen7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7342 : TriggerState {
            internal StateSafeGreen7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 2) {
                    context.State = new StateCheckSameUserTag7342(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7342 : TriggerState {
            internal StateCheckSameUserTag7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9340) && context.GetUserCount(boxId: 9340) == 2) {
                    context.State = new StateEnable7342(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9340)) {
                    context.State = new StateSafeGreen7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7342 : TriggerState {
            internal StateEnable7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001196}, arg2: 0)) {
                    context.State = new StateActivate7342(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7342 : TriggerState {
            internal StateActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: true);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7342(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7342 : TriggerState {
            internal StateDelay7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001212}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 2) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001212}, arg2: 0)) {
                    context.State = new StateDeActivate7342(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7342 : TriggerState {
            internal StateDeActivate7342(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7342(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7343 : TriggerState {
            internal StateSensor7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 3) {
                    context.State = new StateSafeGreen7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7343 : TriggerState {
            internal StateSafeGreen7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 3) {
                    context.State = new StateCheckSameUserTag7343(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7343 : TriggerState {
            internal StateCheckSameUserTag7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9340) && context.GetUserCount(boxId: 9340) == 3) {
                    context.State = new StateEnable7343(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9340)) {
                    context.State = new StateSafeGreen7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7343 : TriggerState {
            internal StateEnable7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001196}, arg2: 0)) {
                    context.State = new StateActivate7343(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7343 : TriggerState {
            internal StateActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: true);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7343(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7343 : TriggerState {
            internal StateDelay7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001212}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 3) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001212}, arg2: 0)) {
                    context.State = new StateDeActivate7343(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7343 : TriggerState {
            internal StateDeActivate7343(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7343(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7344 : TriggerState {
            internal StateSensor7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 4) {
                    context.State = new StateSafeGreen7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7344 : TriggerState {
            internal StateSafeGreen7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 4) {
                    context.State = new StateCheckSameUserTag7344(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7344 : TriggerState {
            internal StateCheckSameUserTag7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9340) && context.GetUserCount(boxId: 9340) == 4) {
                    context.State = new StateEnable7344(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9340)) {
                    context.State = new StateSafeGreen7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7344 : TriggerState {
            internal StateEnable7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001196}, arg2: 0)) {
                    context.State = new StateActivate7344(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7344 : TriggerState {
            internal StateActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: true);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7344(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7344 : TriggerState {
            internal StateDelay7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001212}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 4) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001212}, arg2: 0)) {
                    context.State = new StateDeActivate7344(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7344 : TriggerState {
            internal StateDeActivate7344(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7344(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSensor7345 : TriggerState {
            internal StateSensor7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 1);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 0);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 5) {
                    context.State = new StateSafeGreen7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSafeGreen7345 : TriggerState {
            internal StateSafeGreen7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7340, key: "Color34", value: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) == 5) {
                    context.State = new StateCheckSameUserTag7345(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckSameUserTag7345 : TriggerState {
            internal StateCheckSameUserTag7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckSameUserTag(triggerBoxId: 9340) && context.GetUserCount(boxId: 9340) == 5) {
                    context.State = new StateEnable7345(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (!context.CheckSameUserTag(triggerBoxId: 9340)) {
                    context.State = new StateSafeGreen7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnable7345 : TriggerState {
            internal StateEnable7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg1: new[] {9340}, arg2: "DDStop_Stage_Shiled_01");
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001196}, arg2: 0)) {
                    context.State = new StateActivate7345(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9340) != 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivate7345 : TriggerState {
            internal StateActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: true);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10001196}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDelay7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay7345 : TriggerState {
            internal StateDelay7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001212}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9340) != 5) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001212}, arg2: 0)) {
                    context.State = new StateDeActivate7345(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDeActivate7345 : TriggerState {
            internal StateDeActivate7345(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSensor7345(context);
                    return;
                }

                if (context.GetUserValue(key: "Barrier34") == 10) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8341, 8342, 8343, 8344, 8345, 8346}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {8340}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001196, 10001212}, arg2: 0);
                context.SetUserValue(key: "Barrier34", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}