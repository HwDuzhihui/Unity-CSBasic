using UnityEngine;
using System.Collections;

public class Learn_params : MonoBehaviour {

	void Start () {
        UseParams(1,"Titian",1.44f);

        //NoUseParams(1, "Titian", 1.44f);                   //写法错误
        object[] o = new object[] { 1, "Titan", 1.44f };
        NoUseParams(o);
	}


    void UseParams(params object[] m)                    //params代表参数是可变的。数组在堆区、会损耗一定性能
    {
        Debug.Log("params");
    }
    void NoUseParams(object[] m)
    {
        Debug.Log("No params");
    }
}
