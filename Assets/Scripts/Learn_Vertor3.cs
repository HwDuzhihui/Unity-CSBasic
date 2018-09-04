using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn_Vertor3 : MonoBehaviour {


	void Start () {

        
        //Vector3.Angle() [0,180]
        //两个向量的夹角
        Vector3 a0 = new Vector3(0, 1, 1);
        Vector3 a1 = new Vector3(2, 1, 0);
        float angle0 = Vector3.Angle(a0, a1);
        Debug.Log(a0 + " " + a1 + " 以原点为夹角的角度 " + angle0);
        //计算以b0为原点，b0a0,b0a1的夹角
        Vector3 b0 = new Vector3(2, 2, 2);
        float angle1 = Vector3.Angle(b0 - a0, b0 - a1);
        Debug.Log(a0 + " " + a1 + " 以b0为夹角的角度 " + angle1);

        //叉积Vector3.Cross() 
        //得到同时垂直于两个这两个向量的法向量
        Vector3 cross = Vector3.Cross(a0.normalized, a1.normalized);
        Debug.DrawLine(Vector3.zero, a0, Color.red, 10000);
        Debug.DrawLine(Vector3.zero, a1, Color.red, 10000);
        Debug.DrawLine(Vector3.zero, cross,Color.red,10000);
        Debug.Log("cross = " + cross);
        //弧度
        float radians = Mathf.Asin(Vector3.Distance(Vector3.zero, Vector3.Cross(a0.normalized, a1.normalized)));
        //夹角
        float angle2 = radians * Mathf.Rad2Deg;
        Debug.Log(a0 + " " + a1 + " 以原点为夹角的角度 " + angle2 + "  弧度 " + radians + " 叉积 " + cross);

        if(cross.y > 0)
        {
            //a1在a0顺时针右边
        }
        else if ( cross.y < 0)
        {
            //a1在a0逆时针左边
        }
        else
        {
            //a1和a0平行
        }

        //点积Vector3.Dot()
        float dot = Vector3.Dot(a0.normalized, a1.normalized);
        float angle3 = Mathf.Acos(Vector3.Dot(a0.normalized, a1.normalized)) * Mathf.Rad2Deg;
        Debug.Log(a0 + " " + a1 + " " + "以原点为夹角的角度 " + angle3 + " 弧度 " + radians + " 点积 " + dot);
        if (dot > 0)
        {
            //a1在a0前方
        }
        else if (dot < 0)
        {
            //a1在a0后方
        }
        else
        {
            //1正前方-1正后方
        }

        //Vector3.BetweenAngle
        //返回一个向量的拷贝，并限制最大长度
        Vector3 v0 = new Vector3(0, 5, 0);
        Vector3 clampMagnitude = Vector3.ClampMagnitude(v0,3);
        Debug.Log("clampMagnitude = " + clampMagnitude);

        //Vector3.Magnitude
        //返回向量的长度
        float magnitude = Vector3.Magnitude(new Vector3(1,5,0));
        Debug.Log("magnitude = " + magnitude);
        //Vector3.SqrMagnitude
        //返回向量长度的平方
        float sqrMagnitude = Vector3.SqrMagnitude(new Vector3(1, 5, 0));
        Debug.Log("sqrMagnitude = " + sqrMagnitude);

        //Vector3.Max
        //返回两个向量的最大组成
        Vector3 max = Vector3.Max(new Vector3(10, 3, 5), new Vector3(1, 4, 100));
        Debug.Log("max = " + max);
        //Vector3.Min
        //返回两个向量的最小组成
        Vector3 min = Vector3.Min(new Vector3(10, 3, 5), new Vector3(1, 4, 100));
        Debug.Log("min = " + min);

        //Vector3.Normalized
        //归一化，只比较方向不比较长度
        Vector3 normalized = (new Vector3(10, 2, 3)).normalized;
        Debug.Log("normalized = " + normalized);
        //Vector3.OrthoNormalize
        //归一化并彼此相互垂直对第二个第三个参照第一个进行正交化处理
        Vector3 ort0 = new Vector3(1, 2, 3);
        Vector3 ort1 = new Vector3(4, 5, 6);
        Debug.DrawLine(Vector3.zero, ort0, Color.green, 1000);
        Debug.DrawLine(Vector3.zero, ort1, Color.green, 1000);
        Debug.Log("ort0.normalize = " + ort0.normalized + " ort1.normalize = " + ort1.normalized);
        Vector3.OrthoNormalize(ref ort0,ref ort1);
        Debug.Log("ort0 = " + ort0 + " ort1 = " + ort1);
        Debug.DrawLine(Vector3.zero, ort0, Color.blue, 1000);
        Debug.DrawLine(Vector3.zero, ort1, Color.blue, 1000);

        //Vector3.Project
        //返回p0在p1上的投影向量
        Vector3 p0 = new Vector3(1, 5, 7);
        Vector3 p1 = new Vector3(2, 8, 8);
        Vector3 project = Vector3.Project(p0,p1);
        Debug.Log("Project = " + project);
        //Debug.DrawLine(Vector3.zero, p0, Color.black, 1000);
        //Debug.DrawLine(Vector3.zero, p1, Color.black, 1000);
        //Debug.DrawLine(Vector3.zero, project, Color.blue, 1000);

        //Vector3.Reflect
        //反射向量,沿着reflect1的法线(垂直于reflect1)的反射向量
        Vector3 reflect0 = new Vector3(0, 3, 2);
        Vector3 reflect1 = Vector3.Reflect(reflect0, Vector3.up);
        Debug.DrawLine(Vector3.zero, reflect0, Color.gray, 1000);
        Debug.DrawLine(Vector3.zero, Vector3.up, Color.yellow, 1000);
        Debug.DrawLine(Vector3.zero, reflect1, Color.black, 1000);

        //Vector3.Scale
        //返回向量a和b的乘积
        Vector3 scale = Vector3.Scale(new Vector3(1, 2, 3), new Vector3(4, 5, 6));
        Debug.Log(" scale = " + scale);

        
    }


    public bool isLerp;
    public bool isLerpUnclamped;
    public bool isMoveTowards;
    public bool isRotateTowards;
    public bool isSlerp;
    public bool isSlerpUnclamped;
    public bool isSmoothDamp;

    float lerpS;
    float smoothTime = 2;
    Vector3 velocity;

    void Update () {
		
        if(isLerp)
        {
            //Vertor3.Lerp
            //线性插值
            //正确的线性用法
            lerpS += 1f * Time.deltaTime;
            transform.position = Vector3.Lerp(transform.position, new Vector3(0, 20, 100), lerpS);
        }
        else if(isLerpUnclamped)
        {
            //Vertor3.LerpUnclamped
            //非钳制线性插值，可以突破0和1的界限(t是百分比)
            transform.position = Vector3.LerpUnclamped(transform.position, new Vector3(0, 20, 100), Time.deltaTime);
        }
        else if(isMoveTowards)
        {
            //Vertor3.MoveTowards
            //移向
            //speed可以为负，就是target的反方向
            float speed = 5;
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 20, 100), Time.deltaTime * speed);
        }
        else if(isRotateTowards)
        {
            //Vector3.RotateTowards(起始坐标,目标坐标,角度旋转系数,模长系数)
            //转向
            //用的比较少,资料也比较少
            float speed = 5;
            transform.position = Vector3.RotateTowards(transform.position, new Vector3(0, 20, 100), Time.deltaTime * speed,Time.deltaTime * speed);
        }
        else if(isSlerp)
        {
            //Vertor3.SLerp
            //球形插值
            //百度到的解释：这里球形插值与线性插值不同的地方在于，它将Vectors视为方向而不再是点。返回的向量方向，它的角度是根据a和b的角度插值，而它的长度是根据a和b的长度插值。
            transform.position = Vector3.Slerp(transform.position, new Vector3(0, 20, 100), Time.deltaTime);
        }
        else if(isSlerpUnclamped)
        {
            //Vertor3.SLerp
            //非钳制球形插值,可以突破0和1的界限(t是百分比)
            transform.position = Vector3.SlerpUnclamped(transform.position, new Vector3(0, 20, 100), Time.deltaTime);
        }
        else if(isSmoothDamp)
        {
            //Vector3.SmoothDamp
            //阻尼运动
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(0, 20, 100),ref velocity, smoothTime);
            //错误用法
            //Vector3 smoothTmp = Vector3.zero;
            //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(0, 20, 100), ref smoothTmp, smoothTime);
        }
    }
}
