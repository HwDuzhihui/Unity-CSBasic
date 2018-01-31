using UnityEngine;
using System.Collections;
using System;
public class Learn_sort : MonoBehaviour {

	void Start () {
        int[] m = {2,1,4,9,6,2,7};
        for(int i=0; i<m.Length; i++)
        {
            for(int j=0;j<m.Length-1;j++)           //n * (n-1)
            {
                if(m[i] > m[j])
                {
                    int p = m[j];
                    m[j] = m[i];                 //交换位置
                    m[i] = p;
                }
            }
        }
        foreach(int i in m)
        {
            Debug.Log(i);
        }
        Learn_T_Lis<int>(23);
	}
    public void Learn_T_Lis<T>(T t) //where T : class
    {
    }
}
class Class_T<T> : MonoBehaviour where T : class 
{
}
