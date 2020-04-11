namespace KoiKoi {
    using Deirin.StateMachine;

    public abstract class SM_Gameplay_BaseState : StateBase {
        protected GameplayContext context;

        protected override void CustomSetup () {
            context = data as GameplayContext;
        }
    }
}