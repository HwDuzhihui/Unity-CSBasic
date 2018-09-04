using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn_Quaternion : MonoBehaviour {

	// Use this for initialization
	void Start () {


        //坐标变换包括旋转、平移、缩放
        //欧拉旋转、四元数、矩阵旋转

        //欧拉旋转缺点是有万象锁的存在，欧拉旋转是按照一定顺序旋转Unity是ZXY,当有两个轴向重合时会丢失一个重合方向的旋转能力


        Vector3 v0 = new Vector3(0, 1, 1);
        Vector3 v1 = new Vector3(-2, 1, 0);
        //欧拉角转四元数
        Quaternion qua0 = Quaternion.Euler(v0);
        Quaternion qua1 = Quaternion.Euler(v1);
        //四元数取欧拉角
        Vector3 v3 = qua0.eulerAngles;


        //Quaternion.Angle
        //两个四元数的夹角、返回的夹角不是某个局部坐标轴向变换的夹角，而是GameObject对象从状态a转换到状态b时需要旋转的最小夹角。
        float angle0 = Quaternion.Angle(qua0, qua1);
        float angle1 = Vector3.Angle(v0, v1);
        Debug.Log("qua0 =" + qua0.eulerAngles + " qua1 = " + qua1.eulerAngles + "angle0 = " + angle0 + " angle1 = " + angle1);


        //Quaternion.AngleAxis
        //绕某个轴旋转
        //绕X轴旋转
        //transform.rotation = Quaternion.AngleAxis(30, Vector3.right);
        //绕Y轴旋转
        //transform.rotation = Quaternion.AngleAxis(30, Vector3.up);


        //两个旋转的点积
        float dot = Quaternion.Dot(qua0,qua1);
        Debug.Log("qua0 " + qua0 + "qua1" + qua1 + "dot = " + dot);

        if(dot == 1)
        {
            //qua0和qua1对应的欧拉角相等
        }


    }


    public bool isFromToRotate;

    void Update () {
		
        if(isFromToRotate)
        {
            transform.rotation = Quaternion.FromToRotation(Vector3.up, transform.forward);
        }
	}
}
