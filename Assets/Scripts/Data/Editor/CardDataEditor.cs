using UnityEditor;
using KoiKoi;

[CustomEditor( typeof( CardData ) )]
public class CardDataEditor : Editor {
    SerializedProperty suit;
    SerializedProperty type;
    SerializedProperty ribbonType;

    private void OnEnable () {
        type = serializedObject.FindProperty( "type" );
        suit = serializedObject.FindProperty( "suit" );
        ribbonType = serializedObject.FindProperty( "ribbonType" );
    }

    public override void OnInspectorGUI () {
        serializedObject.Update();

        EditorGUILayout.PropertyField( suit );
        EditorGUILayout.PropertyField( type );
        EditorGUILayout.Space();
        switch ( type.intValue ) {
            case ( int ) CardData.Type.Ribbon:
            EditorGUILayout.PropertyField( ribbonType );
            break;
        }

        serializedObject.ApplyModifiedProperties();
    }
}