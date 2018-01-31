using UnityEngine;
using System.Collections;

public class Learn_is : MonoBehaviour {
	void Start () {
        Learn_isClass2 s = new Learn_isClass2();
        s.ob();
	}                                 //括号结束，release +1  (Debug:(构造函数 isString 析构函数))
}
internal class Learn_isClass2
{
    public string id = "2123";

    public delegate void objectIsString();
    public objectIsString ob;

    public void WhereIdIsString()
    {
        if(id is string)              //是否是string类型
        {
            Debug.Log("isString");
        }
    }
    public Learn_isClass2()
    {
        ob = new objectIsString(WhereIdIsString);             
        Debug.Log("构造函数");
    }
    ~Learn_isClass2()               //析构函数(类对象销毁时执行)
    {
        Debug.Log("析构函数");
    }
}
