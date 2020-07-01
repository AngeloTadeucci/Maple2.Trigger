namespace Maple2.Trigger._84000015_wd {
    public static class _84000015_wait {
        public class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "Weddingceremonyfail", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작_타이머설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작_타이머설정 : TriggerState {
            internal State시작_타이머설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "4000", arg2: 2100, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State위치세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위치세팅 : TriggerState {
            internal State위치세팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000015, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override void Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: true)) {
                    context.State = new State둘다입장(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4000")) {
                    context.State = new State강퇴안내(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State위치돌림 : TriggerState {
            internal State위치돌림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000015, arg2: new byte[] {22, 23}, arg3: 701);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State위치세팅(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기01 : TriggerState {
            internal State대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400131, textId: 28400131);
            }

            public override void Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: true)) {
                    context.State = new State둘다입장(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4000")) {
                    context.State = new State강퇴안내(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400131);
            }
        }

        private class State둘다입장 : TriggerState {
            internal State둘다입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400133, textId: 28400133);
                context.SetUserValue(key: "StartWedding", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "StartWedding") == 1) {
                    context.State = new State결혼확인띄우기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4000")) {
                    context.State = new State강퇴안내(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 28400133);
            }
        }

        private class State결혼확인띄우기 : TriggerState {
            internal State결혼확인띄우기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WeddingMutualAgree(agreeType: "startActing");
                context.SetUserValue(triggerId: 4002, key: "Weddingceremonystartsready", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State결혼시작체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State결혼시작체크 : TriggerState {
            internal State결혼시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WeddingEntryInField(entryType: "GroomBride", isInField: false)) {
                    context.State = new State대기01(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "startActing", success: true)) {
                    context.State = new State결혼식연출진행중(context);
                    return;
                }

                if (context.WeddingMutualAgreeResult(agreeType: "startActing", success: false)) {
                    context.State = new State대기01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "4000")) {
                    context.State = new State강퇴안내(context);
                    return;
                }
            }

            public override void OnExit() {
                context.WeddingMoveUser(entryType: "Guest", arg1: 84000015, arg2: new byte[] {22, 23}, arg3: 701);
            }
        }

        private class State강퇴안내 : TriggerState {
            internal State강퇴안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 28400132, textId: 28400132);
                context.WeddingBroken();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State강퇴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State강퇴 : TriggerState {
            internal State강퇴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 28400132);
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State결혼식연출진행중 : TriggerState {
            internal State결혼식연출진행중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 4001, key: "Weddingceremonystarts", value: 1);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Weddingceremonyfail") == 1) {
                    context.SetUserValue(key: "Weddingceremonyfail", value: 0);
                    context.State = new State위치세팅(context);
                    return;
                }

                if (context.WeddingHallState(hallState: "weddingComplete")) {
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