namespace KoiKoi {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class Player : MonoBehaviour {
        [Header("References")]
        public Hand hand;

        public void Active ( bool value ) {
            hand.Active( value );
        }
    }
}