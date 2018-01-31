using UnityEngine;
using System.Collections;

public class learn_goto : MonoBehaviour {
	void Start () {
        for(int i=0; i<5; i++)
        {
            if(i == 3)
            {
                goto aaaaa;               //相当于执行aaaaa方法后break
            }
            Debug.Log("i = " + i);       //i=1,i=2
        }
        goto bbbbb;
        aaaaa:
        Debug.Log("Log:aaaaa");
        bbbbb:
        Debug.Log("Log:bbbbb");
        LearnGoto_Switch();
	}
    void LearnGoto_Switch()
    { 
        int m = 1;
        switch(m)
        {
            case 1:
                goto case 4;          //直接执行4号case
            case 2:
                break;
            case 3:
                Debug.Log("Log:" + 33333);
                break;
            case 4:
                Debug.Log("Log:" + 44444);    
                goto case 3;                 //执行3号
        }
    }
}
