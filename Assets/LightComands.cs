using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ScriptBase))]

public class LightComands : Editor
{  

    public override void OnInspectorGUI()
    {
        ScriptBase game = (ScriptBase)target;

        if(GUILayout.Button("Trocar LightType")) game.ChangeLightType();        

        //Como alterar a cor
        game.LightComp.color = EditorGUILayout.ColorField("Cor", game.LightComp.color);

        //Como alterar o Range
        if(GUILayout.Button("Trocar Range")) game.LightComp.range = Random.Range(0,100);

        //Como anterar a Intensity
        if (GUILayout.Button("Trocar Intensity")) game.LightComp.intensity = Random.Range(0, 10);
    }   

}
