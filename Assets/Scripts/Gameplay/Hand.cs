namespace KoiKoi {
    using UnityEngine;
    using DG.Tweening;
    using System.Collections.Generic;

    public class Hand : CardContainer {
        [Header("Paramteres")]
        public float cardDistance;

        private Vector3 startPosition;

        #region API
        public void UpdateGraphics () {
            int count = cards.Count;
            startPosition.Set( transform.position.x, transform.position.y, transform.position.z - ( count * cardDistance * .5f ) );
            for ( int i = 0; i < count; i++ ) {
                Card card = cards[i];
                if ( card.gameObject.activeSelf == false )
                    card.gameObject.SetActive( true );

                card.transform.DOMove( startPosition + transform.forward * cardDistance * i, 1f );
                card.transform.DORotateQuaternion( transform.rotation, 1f );
            }
        }

        public void Active ( bool value ) {
            if ( cards == null )
                cards = new List<Card>();
            foreach ( Card card in cards ) {
                card.SetState( value ? Card.State.Hand : Card.State.Inactive );
            }
        }
        #endregion

        #region Overrides
        protected override void OnCardAdd ( Card card ) {
            UpdateGraphics();
        }

        protected override void OnCardRemove ( Card card ) {
            UpdateGraphics();
        }
        #endregion
    }
}