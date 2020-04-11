namespace KoiKoi {
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class CardContainer : MonoBehaviour {
        protected List<Card> cards;

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

        protected virtual void OnCardAdd ( Card card ) {

        }

        protected virtual void OnCardRemove ( Card card ) {

        }
    }
}