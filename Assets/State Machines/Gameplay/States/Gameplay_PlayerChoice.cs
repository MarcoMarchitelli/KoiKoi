namespace KoiKoi {
    public class Gameplay_PlayerChoice : SM_Gameplay_BaseState {
        public override void Enter () {
            context.playerA.Active( true );
            context.playerB.Active( false );
            context.GoNext();
        }
    }
}