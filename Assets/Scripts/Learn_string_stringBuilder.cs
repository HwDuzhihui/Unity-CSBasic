using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;

public class Learn_string_stringBuilder : MonoBehaviour {

	// Use this for initialization
	void Start () {

        string a1 = "abc";    //分配固定的内存大小
        a1 += "def";         //销毁原先的数据再来分配，代价比较昂贵

        StringBuilder sb = new StringBuilder(20);      //指定分配大小
        sb.Append("abc");                             //分配到堆区
        sb.Append("def");　　                        //不会被销毁，而是直接追加到后面。

    }
	
}
