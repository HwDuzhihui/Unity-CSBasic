using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


public class Learn_Editor_Test : EditorWindow {

    [MenuItem("Tools/Window")]
    static void CreateWindow()
    {
        // 在这里面创建窗口
        GetWindow(typeof(Learn_Editor_Test), false, "Learn_Editor_Test", true);
    }


    string text;
    bool tips;

    void OnGUI()
    {
        EditorGUILayout.BeginFadeGroup(1);
        //一行
        EditorGUILayout.BeginHorizontal();
        GUILayout.Label("名字");
        text = EditorGUILayout.TextField(text);
        tips = EditorGUILayout.Toggle("性别", tips);
        EditorGUILayout.EndHorizontal();

        if(GUILayout.Button("Button1"))
        {
            Debug.Log("已确认 " + text + " " + tips);
        }

        EditorGUILayout.EndFadeGroup();

    }
}
