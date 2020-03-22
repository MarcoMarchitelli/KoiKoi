using UnityEditor;
using KoiKoi;

[CustomEditor( typeof( Meld ) )]
public class MeldEditor : Editor {
    SerializedProperty type;
    SerializedProperty cards;
    SerializedProperty cardType;
    SerializedProperty count;
    SerializedProperty points;
    SerializedProperty cardRibbonType;

    private void OnEnable () {
        type = serializedObject.FindProperty( "type" );
        cards = serializedObject.FindProperty( "cards" );
        cardType = serializedObject.FindProperty( "cardType" );
        count = serializedObject.FindProperty( "count" );
        points = serializedObject.FindProperty( "points" );
        cardRibbonType = serializedObject.FindProperty( "cardRibbonType" );
    }

    public override void OnInspectorGUI () {
        serializedObject.Update();

        EditorGUILayout.PropertyField( type );
        EditorGUILayout.Space();
        switch ( type.intValue ) {
            case ( int ) Meld.Type.Specific:
            EditorGUILayout.PropertyField( cards );
            break;
            case ( int ) Meld.Type.Count:
            EditorGUILayout.PropertyField( cardType );
            switch ( cardType.intValue ) {
                case ( int ) CardData.Type.Ribbon:
                EditorGUILayout.PropertyField( cardRibbonType );
                break;
            }
            EditorGUILayout.PropertyField( count );
            break;
        }
        EditorGUILayout.PropertyField( points );

        serializedObject.ApplyModifiedProperties();
    }
}