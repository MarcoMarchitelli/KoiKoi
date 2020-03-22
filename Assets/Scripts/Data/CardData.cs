namespace KoiKoi {
    using UnityEngine;

    [CreateAssetMenu( menuName = "KoiKoi/Card" )]
    public class CardData : ScriptableObject {
        [Header("Parameters")]
        public Suit suit;
        public Type type;
        public RibbonType ribbonType;

        public enum Suit {
            Pine,
            PlumBlossoms,
            CherryBlossoms,
            Wisteria,
            Iris,
            Peony,
            Clover,
            Pampas,
            Chrysanthemum,
            Maple,
            Willow,
            Paulownia
        }

        public enum Type {
            Base,
            Ribbon,
            Bright,
            Animal
        }

        public enum RibbonType {
            Red,
            Purple
        }
    } 
}