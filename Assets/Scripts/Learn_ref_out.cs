using UnityEngine;
using System.Collections;

public class Learn_ref_out : MonoBehaviour {

    //相当于放到函数里进行处理运算
	void Start () {

        string s1 = "p1";                                         //可以有多个ref，必须初始化(侧重修改)
        int s2 = 1; 
        object s3 = "p3"; 
        Use_ref(ref s1,ref s2,ref s3);                            
        Debug.Log(string.Format("s1= {0}s2= {1}s3= {2}",s1,s2,s3));

        int i;                                                 //只能存在一个out，函数里必须赋值,可以不初始化(侧重输出)
        Use_out(1, 2, out i);
        Debug.Log("m= 3__ " + i);

	}
	
    void Use_ref(ref string s, ref int m,ref object n)
    {
        //ref可以不处理
    }
    int Use_out(int a,int b,out int c)
    {
        //out必须赋值
        c = a + b;
        return c;
    }
}
