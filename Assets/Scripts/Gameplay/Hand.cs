namespace KoiKoi {
    using UnityEngine;
    using DG.Tweening;

    public class Hand : CardContainer {
        [Header("Paramteres")]
        public float cardDistance;

        private Vector3 startPosition;

        #region API
        public void UpdateGraphics () {
            int count = cards.Count;
            startPosition.Set( transform.position.x - ( count / 2.5f ), transform.position.y, transform.position.z );
            for ( int i = 0; i < count; i++ ) {
                cards[i].transform.DOMove( startPosition + Vector3.right * cardDistance * i, 1f );
            }
        }

        public void Active ( bool value ) {
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