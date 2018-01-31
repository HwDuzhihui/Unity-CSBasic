using UnityEngine;
using System.Collections;

public class Learn_delegate : MonoBehaviour {

	void Start () {
        Connect(4, 5, null);
	}

    void Connect(int a,int b, delegate_class2 linster)
    {
        if(linster == null)
        {
            linster = new delegate_class2();
        }
        linster.Compare_del(a, b);
        linster.Addtive(a, b);
        linster.Substraction(a, b);
        linster.Division(a, b);
    }
}
sealed class delegate_class2                                          //加减乘除代理类
{
    public delegate void AddtiveDelegate(int a, int b);
    public delegate void SubtractionDelegate(int a, int b);
    public delegate void CompareDelegate(int a, int b);
    public delegate void DivisionDelegate(int a,int b);

    public CompareDelegate Compare_del;
    public AddtiveDelegate Addtivew_del;
    public SubtractionDelegate Subtra_del;
    public DivisionDelegate Division_del;

    public delegate_class2()
    {
        Addtivew_del = new AddtiveDelegate(Addtive);
        Subtra_del = new SubtractionDelegate(Substraction);
        Compare_del = new CompareDelegate(Compare);
        Division_del = new DivisionDelegate(Division);
    }
    public void Addtive(int a, int b)
    {
        Debug.Log(a + b);
    }
    public void Substraction(int a, int b)
    {
        Debug.Log(a - b);
    }
    public void Compare(int a, int b)
    {
        Debug.Log((a > b).ToString());
    }
    public void Division(int a,int b)
    {
        Debug.Log((double)a/b);
    }
}