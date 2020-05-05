namespace KoiKoi {
    using UnityEngine;

    public class Gameplay_Setup : SM_Gameplay_BaseState {
        [Header("Prefabs")]
        public Card cardPrefab;

        [Header("Data")]
        public DeckData deckData;

        private Card tempCard;

        public override void Enter () {
            //inst all cards
            foreach ( CardData cardData in deckData.cards ) {
                tempCard = Instantiate( cardPrefab, context.deck.transform );
                tempCard.SetCardData( cardData );
                tempCard.gameObject.SetActive( false );
                context.deck.AddCard( tempCard );
            }

            //gamplay elements setup
            context.board.Setup();
            context.playerA.Setup();
            context.playerB.Setup();

            //setup deck and shuffle
            context.deck.Setup();
            context.deck.Shuffle();

            context.Next();

#if UNITY_EDITOR
            Debug.Log("Setup done!");
#endif
        }
    }
}