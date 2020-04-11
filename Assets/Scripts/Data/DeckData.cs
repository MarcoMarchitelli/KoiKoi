namespace KoiKoi {
    using UnityEngine;

    [CreateAssetMenu( menuName = "KoiKoi/Deck" )]
    public class DeckData : ScriptableObject {
        [Header("Parameters")]
        public CardData[] cards;
    }
}