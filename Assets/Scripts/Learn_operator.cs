using UnityEngine;
using System.Collections;


//运算符重载、对象之间可以进行运算
public class Learn_operator : MonoBehaviour {

    private int num1,num2;

    public Learn_operator(int num1,int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }

    public static Learn_operator operator +(Learn_operator a, Learn_operator b)
    {
        return new Learn_operator(a.num1 * b.num2 + a.num2 * b.num1, a.num2 * b.num2);
    }

    public static Learn_operator operator *(Learn_operator a, Learn_operator b)
    {
        return new Learn_operator(a.num1 * b.num1 , a.num2 * b.num2);
    }

    public static implicit operator double(Learn_operator a)           //implicit隐式转换
    {
        return (double)a.num1/a.num2;
    }
    public static explicit operator Learn_explicit(Learn_operator a)   //explicit显示转换
    {
        return (Learn_explicit)a.num2;
    }

	void Start () {

        Learn_operator a = new Learn_operator(2, 3);
        Learn_operator b = new Learn_operator(4, 5);
        Learn_operator c = new Learn_operator(6, 7);

        Debug.Log((double)(a * b + c));           //上面进行了重载操作(没重载会报错)、可以进行运算
        Debug.Log((Learn_explicit)a);
	}
	
}
public enum Learn_explicit
{
    explicit_A = 2,
    explicit_B = 3
}