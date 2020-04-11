namespace KoiKoi {
    using UnityEngine;

    public class Board : CardContainer {
        [Header("Parameters")]
        public Slot[] slots;

        private Slot tempSlot;

        protected override void OnCardAdd ( Card card ) {
            for ( int i = 0; i < slots.Length; i++ ) {
                tempSlot = slots[i];
                if ( tempSlot.empty ) {
                    tempSlot.SetCard( card );
                }
            }
        }
    }
}