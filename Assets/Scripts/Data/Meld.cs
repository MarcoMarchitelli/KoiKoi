namespace KoiKoi {
    using UnityEngine;

    [CreateAssetMenu( menuName = "KoiKoi/Meld" )]
    public class Meld : ScriptableObject {
        public Type type;

        public CardData[] cards;

        public CardData.Type cardType;
        public CardData.RibbonType cardRibbonType;
        public int count;

        public int points;

        public enum Type {
            Specific,
            Count
        }
    }
}