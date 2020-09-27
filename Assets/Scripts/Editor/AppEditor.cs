using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(App))]
public class AppEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GUILayout.Label("String");
        App app = (App)target;
        if(GUILayout.Button("Save changes"))
        {

        }
    }
}
