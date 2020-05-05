namespace KoiKoi {
    using UnityEngine;

    public class Player : MonoBehaviour {
        [Header("References")]
        public Hand hand;

        public void Setup () {
            hand.Setup();
        }

        public void Active ( bool value ) {
            hand.Active( value );
        }
    }
}