namespace KoiKoi {
    using UnityEngine;
    using DG.Tweening;
    using Deirin.CustomButton;

    public class Card : MonoBehaviour {
        public enum State { Inactive, Hand, Field }

        [Header("References")]
        public SpriteRenderer spriteRenderer;
        public CustomButton_World customButton;

        public CardData CardData => cardData;
        public State CurrentState => state;

        private CardData cardData;
        private State state;
        private Vector3 startScale;

        private void Awake () {
            startScale = transform.localScale;
        }

        #region API
        public void SetCardData ( CardData data ) {
            cardData = data;
        }

        public void UpdateGraphics () {
            spriteRenderer.sprite = cardData?.sprite;
        }

        public void SetState( State state ) {
            if ( this.state == state )
                return;

            this.state = state;
            switch ( state ) {
                case State.Inactive:
                customButton.Active( false );
                break;
                case State.Hand:
                customButton.Active( true );
                break;
                case State.Field:
                customButton.Active( true );
                break;
                default:
                break;
            }
        }
        #endregion

        #region Mouse Events Handlers
        public void MouseEnterHandler () {
            switch ( state ) {
                case State.Inactive:
                break;
                case State.Hand:
                transform.DOScale( startScale * 1.3f, .5f );
                break;
                case State.Field:
                break;
            }
        }

        public void MouseExitHandler () {
            switch ( state ) {
                case State.Inactive:
                break;
                case State.Hand:
                transform.DOScale( startScale, .5f );
                break;
                case State.Field:
                break;
            }
        }

        public void MouseDownHandler () {
            switch ( state ) {
                case State.Inactive:
                break;
                case State.Hand:
                break;
                case State.Field:
                break;
            }
        }

        public void MouseUpHandler () {
            switch ( state ) {
                case State.Inactive:
                break;
                case State.Hand:
                break;
                case State.Field:
                break;
            }
        }
        #endregion
    }
}