namespace KoiKoi {
    using UnityEngine;

    public class Gameplay_BoardSetup : SM_Gameplay_BaseState {
        public override void Enter () {
            for ( int i = 0; i < 8; i++ ) {
                context.activePlayer.hand.AddCard( context.deck.GetLast() );
            }

            for ( int i = 0; i < 8; i++ ) {
                context.inactivePlayer.hand.AddCard( context.deck.GetLast() );
            }

            for ( int i = 0; i < 8; i++ ) {
                context.board.AddCard( context.deck.GetLast() );
            }

#if UNITY_EDITOR
            Debug.Log( "Hands and board filled!" );
#endif
        }
    }
}