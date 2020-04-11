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

            context.Next();
        }
    }
}