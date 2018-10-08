using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//添加此脚本时增加一个BoxCollider组件
[RequireComponent(typeof(BoxCollider))]

public class Learn_Editor : MonoBehaviour {

    //不显示在面板
    [HideInInspector]
    public int a0;

    //显示在面板并序列化
    [SerializeField]
    private int a1;

    //public默认已经[SerializeField]序列化
    public int a2;

    //右键新建一个按钮
    [MenuItem("Assets/Button")]
    public static void ButtonClick() { }
    //在Create下
    [MenuItem("Assets/Create/Button", false, 0)]
    public static void ButtonCreateClick() { }
    //在上方面板
    [MenuItem("Tools/Button")]
    public static void ButtonTopClick() { }
}
