using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Learn_LINQ : MonoBehaviour {    //Linq查询语句

	void Start () {

        int[] scores = new int[]{21,19,15,24,26,8};
        IEnumerable<int> scoreQuery =                   //IEnumerable、迭代器
            from score in scores 
            where score > 20 
            select score;
        foreach(int i in scoreQuery)
        {
            Debug.Log(i);
        }

        string[] strs = new string[] { "asde23", "23rrfd", "hhhh", "bsbsbs", "qqqqq23" };
        IEnumerable<string> strQuery =
            from str in strs
            where str.Contains("23")
            select str;
        foreach(string s in strQuery)
        {
            Debug.Log(s);
        }
	}

    public TSList GetWouldLike<TSList,TValue>(TValue v) where TSList : class
    {
        return v as TSList ;
    }
    public T GetT<T,TValue>(TValue v)
    {
        T rt = (T)new object();
        return rt;
    }
}
