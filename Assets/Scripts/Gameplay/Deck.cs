﻿namespace KoiKoi {
    using UnityEngine;
    using DG.Tweening;

    public class Deck : CardContainer {
        [Header("References")]
        public Transform deckMesh;

        private float singleCardHeight;

        protected override void CustomSetup () {
            if ( cards.Count > 0 )
                singleCardHeight = deckMesh.localScale.y / cards.Count;
        }

        #region Overrides
        protected override void OnCardAdd ( Card card ) {
            deckMesh.transform.DOScaleY( deckMesh.transform.localScale.y + singleCardHeight, .5f ).SetEase( Ease.OutElastic );
        }

        protected override void OnCardRemove ( Card card ) {
            deckMesh.transform.DOScaleY( deckMesh.transform.localScale.y - singleCardHeight, .5f ).SetEase( Ease.OutElastic );
        }
        #endregion
    }
}