namespace KoiKoi {
    using UnityEngine;

    public class Gameplay_PlayerChoice : SM_Gameplay_BaseState {
        public override void Enter () {
            context.playerA.Active( false );
            context.playerB.Active( false );

            SetDealer();

            context.GoNext();
        }

        private void SetDealer () {
            int index = Random.Range(0, 2);
            if ( index == 0 ) {
                context.dealer = context.activePlayer = context.playerA;
                context.inactivePlayer = context.playerB;
            }
            else {
                context.dealer = context.activePlayer = context.playerB;
                context.inactivePlayer = context.playerA;
            }

#if UNITY_EDITOR
            Debug.Log( "Dealer is: " + context.dealer.name);
#endif
        }
    }
}