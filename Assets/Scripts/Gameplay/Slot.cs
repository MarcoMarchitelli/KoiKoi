namespace KoiKoi {
    using Deirin.Utilities;
    using UnityEngine;

    public class Slot : MonoBehaviour {
        [ReadOnly] public bool empty = true;

        public Card Card => card;

        private Card card;

        public void SetCard ( Card card ) {
            if ( card == null ) {
#if UNITY_EDITOR
                Debug.LogWarning( "Trying to set a null card to " + name + "!" );
#endif
                return;
            }

            if ( this.card != null ) {
#if UNITY_EDITOR
                Debug.LogWarning( "Trying to set a new card to " + name + " who already has one!" );
#endif
                return;
            }

            this.card = card;
            empty = false;
        }

        public Card RemoveCard () {
            empty = true;
            Card tempCard = card;
            card = null;
            return tempCard;
        }
    }
}