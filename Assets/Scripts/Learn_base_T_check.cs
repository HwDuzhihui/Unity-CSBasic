using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using MySdCode.sd;
using System;
namespace MySdCode.sd                                        //base
{
    public abstract class aMyDebug                         //abstract，抽象类,只能被继承不能被实例化。
    {
        //aMyDebug s = new aMyDebug();                      //不能被实例化
        internal   static void aaaaa() { }              //internal,只能这个命名空间访问(默认)
        public     static void bbbbb() { }            //public,所有空间可访问
        protected  static void ccccc() { }           //protected,本类和子类可访问
        private    static void ddddd() { }         //private,只能本类访问
    }
    public sealed class bMyDebug                 //sealed, 密封类，只能被实例化而不能被继承,不能有任何的抽象方法。
    {
        private int ms = 12;
        internal bMyDebug(int a) : this(a,10,12) { }
        internal bMyDebug(int a,int b,int c)
        {
            this.ms = a + b + c;
            Debug.Log("ms = 32" + this.ms);
        }
        public void mmmmm() { }
        //abstract void nnnnn() { }
    }
    //internal class mMyDebug : MyDebug { }
    interface dMyDebug { string nnnnn(); }                            //interface，接口类，子类必须实现接口类的方法 
    class eMyDebug : dMyDebug { public string nnnnn() { return ""; } }   
}
public class Learn_base_T_check : MonoBehaviour
{
	void Start () {
        //bMyDebug b = new bMyDebug(10);
        //b.mmmmm();
        //throw new System.Exception("强制报错");
        //try
        //{
        //    string str = "ad2";
        //    int i = System.Int32.Parse(str);
        //}
        //catch (System.Exception ex)
        //{
        //    Debug.LogError(ex);                  //报错
        //}

        int m = 10;
        int m2 = checked(2147483647 + m);       //checked表示启用溢出检查(默认不启用)此处内存溢出报错
        int m3 = GetInt();
	}
    int GetInt()
    {
        checked
        {
            int m = 10;
            int m2 = 2147483647;
            return m + m2;                   //此处溢出报错
        }
    }
}



namespace Learn_Start_T                          //泛型
{
    public sealed class Learn_T<A,B,C,D,T> 
        where A : struct                      //要求A必须是值类型
        where B : class                      //要求B必须是引用类型
        where C : IComparable                //要求C必须实现了IComparable的接口函数
        where D : B                        //要求D继承自B
        where T : class , new()            //要求T必须是引用类型，并且要有一个无参的构造函数
    {
        public void DebugTheObject(A aaa, B bbb, C ccc, D ddd, T ttt) { }
    }
    internal class Use_Learn_T
    {
        void Start()
        {
            Learn_T<int,Saled,Buul,Saled_Child,Buul> s = new Learn_T<int, Saled, Buul, Saled_Child, Buul>();
            Saled ss = new Saled();    Saled_Child sss = new Saled_Child();    Buul ssss = new Buul();
            s.DebugTheObject(12,ss,ssss,sss,ssss);
        }
    }
    internal class Saled { }
    internal class Saled_Child : Saled { }
    sealed class Buul :IComparable
    {
        public int CompareTo(object value) { return 0; }           //实现IComparable接口函数
        public Buul() { }       public Buul(int m) { }
    }  
}

