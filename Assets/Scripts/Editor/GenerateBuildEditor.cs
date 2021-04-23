using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GenerateBuild))]
public class GenerateBuildEditor : Editor
{
    public override void OnInspectorGUI()
    {

        if (GUILayout.Button("Generate Build"))
        {
            BuildCommand.PerformBuild();
        }
    }
}
