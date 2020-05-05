namespace KoiKoi {
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class CardContainer : MonoBehaviour {
        protected List<Card> cards;
        protected Card tempCard;

        public void Setup () {
            CustomSetup();
        }

        public void AddCard ( Card card ) {
            if ( cards == null )
                cards = new List<Card>();
            cards.Add( card );
            OnCardAdd( card );
        }

        public void RemoveCard ( Card card ) {
            if ( cards == null )
                cards = new List<Card>();
            cards.Remove( card );
            OnCardRemove( card );
        }

        public Card GetLast () {
            if ( cards == null || cards.Count == 0 )
                return null;
            tempCard = cards[cards.Count - 1];
            cards.Remove( tempCard );
            return tempCard;
        }

        public void Shuffle () {
            for ( int i = 0; i < cards.Count; i++ ) {
                tempCard = cards[i];
                int randomIndex = Random.Range(i, cards.Count);
                cards[i] = cards[randomIndex];
                cards[randomIndex] = tempCard;
            }
        }

        protected virtual void OnCardAdd ( Card card ) {

        }

        protected virtual void OnCardRemove ( Card card ) {

        }

        protected virtual void CustomSetup () {

        }
    }
}