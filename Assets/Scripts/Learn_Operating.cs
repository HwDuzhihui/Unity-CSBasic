using UnityEngine;
using System.Collections;

public class Learn_Operating : MonoBehaviour {

	// Use this for initialization
	void Start () {


        //参加运算的两个对象只要有一个为1，其值为1。
        // 3|5　即 0000 0011 | 0000 0101 = 0000 0111   因此，3|5的值得7。
        int m = 3 | 5;
        Debug.Log("m="+ m);

        //两位同时为“1”，结果才为“1”，否则为0
        //3&5  即 0000 0011 & 0000 0101 = 0000 0001   因此，3&5的值得1。
        int n = 3 & 5;
        Debug.Log("n=" + n);

        //14/10
        int a = 6;
        int b = 10;
        a |= b;
        Debug.Log("a=" + a +"b="+b);


        //8（即二进制的00001000）向右移两位等于2（即二进制的00000010）
        //14（即二进制的00001110）向左移两位等于56（即二进制的00111000）
        //2/56
        int x = 8 >> 2;
        int y = 14 << 2;
        Debug.Log("x=" + x + "y=" + y);


	}
}
