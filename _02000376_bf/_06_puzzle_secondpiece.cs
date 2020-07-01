namespace Maple2.Trigger._02000376_bf {
    public static class _06_puzzle_secondpiece {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PickSecondPieceExceptA01", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptA02", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptA03", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptB01", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptB02", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptC01", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptD01", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptD02", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptE01", value: 0);
                context.SetUserValue(key: "PickSecondPieceExceptE02", value: 0);
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PickSecondPieceExceptA01") == 1) {
                    context.State = new StateRandomPick_ExceptA01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptA02") == 1) {
                    context.State = new StateRandomPick_ExceptA02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptA03") == 1) {
                    context.State = new StateRandomPick_ExceptA03(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptB01") == 1) {
                    context.State = new StateRandomPick_ExceptB01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptB02") == 1) {
                    context.State = new StateRandomPick_ExceptB02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptC01") == 1) {
                    context.State = new StateRandomPick_ExceptC01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptD01") == 1) {
                    context.State = new StateRandomPick_ExceptD01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptD02") == 1) {
                    context.State = new StateRandomPick_ExceptD02(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptE01") == 1) {
                    context.State = new StateRandomPick_ExceptE01(context);
                    return;
                }

                if (context.GetUserValue(key: "PickSecondPieceExceptE02") == 1) {
                    context.State = new StateRandomPick_ExceptE02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptA01 : TriggerState {
            internal StateRandomPick_ExceptA01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptA02 : TriggerState {
            internal StateRandomPick_ExceptA02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptA03 : TriggerState {
            internal StateRandomPick_ExceptA03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptB01 : TriggerState {
            internal StateRandomPick_ExceptB01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptB02 : TriggerState {
            internal StateRandomPick_ExceptB02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptC01 : TriggerState {
            internal StateRandomPick_ExceptC01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptD01 : TriggerState {
            internal StateRandomPick_ExceptD01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptD02 : TriggerState {
            internal StateRandomPick_ExceptD02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptE01 : TriggerState {
            internal StateRandomPick_ExceptE01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern10_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRandomPick_ExceptE02 : TriggerState {
            internal StateRandomPick_ExceptE02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern01_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern02_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern03_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern04_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern05_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern06_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern07_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern08_Pick(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new StatePattern09_Pick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Pick : TriggerState {
            internal StatePattern01_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern01_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Check : TriggerState {
            internal StatePattern01_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000565)) {
                    context.State = new StatePattern01_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000565)) {
                    context.State = new StatePattern01_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_CorrectAnswer : TriggerState {
            internal StatePattern01_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3210}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern01_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_WrongAnswer : TriggerState {
            internal StatePattern01_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern01_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Reset01 : TriggerState {
            internal StatePattern01_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern01_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern01_Reset02 : TriggerState {
            internal StatePattern01_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3210}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern01_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Pick : TriggerState {
            internal StatePattern02_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern02_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Check : TriggerState {
            internal StatePattern02_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000566)) {
                    context.State = new StatePattern02_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000566)) {
                    context.State = new StatePattern02_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_CorrectAnswer : TriggerState {
            internal StatePattern02_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3211}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern02_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_WrongAnswer : TriggerState {
            internal StatePattern02_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern02_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Reset01 : TriggerState {
            internal StatePattern02_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern02_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern02_Reset02 : TriggerState {
            internal StatePattern02_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3211}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern02_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Pick : TriggerState {
            internal StatePattern03_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3202}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern03_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Check : TriggerState {
            internal StatePattern03_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000567)) {
                    context.State = new StatePattern03_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000567)) {
                    context.State = new StatePattern03_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_CorrectAnswer : TriggerState {
            internal StatePattern03_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3212}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern03_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_WrongAnswer : TriggerState {
            internal StatePattern03_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern03_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Reset01 : TriggerState {
            internal StatePattern03_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern03_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern03_Reset02 : TriggerState {
            internal StatePattern03_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3212}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern03_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Pick : TriggerState {
            internal StatePattern04_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3203}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern04_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Check : TriggerState {
            internal StatePattern04_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000568)) {
                    context.State = new StatePattern04_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000568)) {
                    context.State = new StatePattern04_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_CorrectAnswer : TriggerState {
            internal StatePattern04_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3213}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern04_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_WrongAnswer : TriggerState {
            internal StatePattern04_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern04_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Reset01 : TriggerState {
            internal StatePattern04_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern04_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern04_Reset02 : TriggerState {
            internal StatePattern04_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3213}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern04_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Pick : TriggerState {
            internal StatePattern05_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3204}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern05_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Check : TriggerState {
            internal StatePattern05_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000569)) {
                    context.State = new StatePattern05_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000569)) {
                    context.State = new StatePattern05_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_CorrectAnswer : TriggerState {
            internal StatePattern05_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3214}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern05_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_WrongAnswer : TriggerState {
            internal StatePattern05_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern05_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Reset01 : TriggerState {
            internal StatePattern05_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern05_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern05_Reset02 : TriggerState {
            internal StatePattern05_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3214}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern05_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Pick : TriggerState {
            internal StatePattern06_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3205}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern06_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Check : TriggerState {
            internal StatePattern06_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000570)) {
                    context.State = new StatePattern06_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000570)) {
                    context.State = new StatePattern06_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_CorrectAnswer : TriggerState {
            internal StatePattern06_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3215}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern06_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_WrongAnswer : TriggerState {
            internal StatePattern06_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern06_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Reset01 : TriggerState {
            internal StatePattern06_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern06_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern06_Reset02 : TriggerState {
            internal StatePattern06_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3215}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern06_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Pick : TriggerState {
            internal StatePattern07_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3206}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern07_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Check : TriggerState {
            internal StatePattern07_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000571)) {
                    context.State = new StatePattern07_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000571)) {
                    context.State = new StatePattern07_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_CorrectAnswer : TriggerState {
            internal StatePattern07_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3216}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern07_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_WrongAnswer : TriggerState {
            internal StatePattern07_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern07_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Reset01 : TriggerState {
            internal StatePattern07_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern07_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern07_Reset02 : TriggerState {
            internal StatePattern07_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3216}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern07_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Pick : TriggerState {
            internal StatePattern08_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3207}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern08_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Check : TriggerState {
            internal StatePattern08_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000572)) {
                    context.State = new StatePattern08_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000572)) {
                    context.State = new StatePattern08_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_CorrectAnswer : TriggerState {
            internal StatePattern08_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3217}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern08_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_WrongAnswer : TriggerState {
            internal StatePattern08_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern08_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Reset01 : TriggerState {
            internal StatePattern08_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern08_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern08_Reset02 : TriggerState {
            internal StatePattern08_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3217}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern08_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Pick : TriggerState {
            internal StatePattern09_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3208}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern09_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Check : TriggerState {
            internal StatePattern09_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000573)) {
                    context.State = new StatePattern09_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000573)) {
                    context.State = new StatePattern09_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_CorrectAnswer : TriggerState {
            internal StatePattern09_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3218}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern09_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_WrongAnswer : TriggerState {
            internal StatePattern09_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern09_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Reset01 : TriggerState {
            internal StatePattern09_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern09_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern09_Reset02 : TriggerState {
            internal StatePattern09_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3218}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern09_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Pick : TriggerState {
            internal StatePattern10_Pick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3209}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern10_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Check : TriggerState {
            internal StatePattern10_Check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000574)) {
                    context.State = new StatePattern10_CorrectAnswer(context);
                    return;
                }

                if (!context.DetectLiftableObject(triggerBoxIds: new[] {2002}, itemId: 30000574)) {
                    context.State = new StatePattern10_WrongAnswer(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_CorrectAnswer : TriggerState {
            internal StatePattern10_CorrectAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 1);
                context.SetMesh(arg1: new[] {3219}, arg2: true, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ResetSecondPiece") == 1) {
                    context.State = new StatePattern10_Reset01(context);
                    return;
                }

                if (context.GetUserValue(key: "LockSecondPiece") == 1) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_WrongAnswer : TriggerState {
            internal StatePattern10_WrongAnswer(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4, key: "CorrectSecondPiece", value: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePattern10_Reset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Reset01 : TriggerState {
            internal StatePattern10_Reset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheckSecondPiece", value: 0);
                context.SetUserValue(key: "CorrectSecondPiece", value: 0);
                context.SetUserValue(key: "ResetSecondPiece", value: 0);
                context.SetUserValue(key: "LockSecondPiece", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePattern10_Reset02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePattern10_Reset02 : TriggerState {
            internal StatePattern10_Reset02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3219}, arg2: false, arg3: 100, arg4: 0, arg5: 5f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "CheckSecondPiece") == 1) {
                    context.State = new StatePattern10_Check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}