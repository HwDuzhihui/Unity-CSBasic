using UnityEngine;
using System.Collections;
using System.Threading;

public class Learn_Lock : MonoBehaviour {
	void Start () {
        UseThread();
	}
    void UseThread()
    {
        Thread[] threads = new Thread[10];
        Account account = new Account(1000);
        for(int i=0; i<10; i++)
        {
            Thread t = new Thread(new ThreadStart(account.ChangeStart));     //设置回调
            threads[i] = t;
            threads[i].Name = "thread:" + i;
        }
        for(int i=0;i<10;i++)
        {
            threads[i].Start();           //开启十个线程执行
        }
    }
    internal class Account      //加锁
    {
        private object lockObj = new object();
        private int num;

        public Account(int i) { num = i; }  //构造方法
        int ChangeNum(int m)
        {
            if(num < 0){
                throw new System.Exception("num value blow 0");
            }

            lock(lockObj)    //如果没有加锁，执行顺序就是乱的，加锁后如果有线程正在访问，后面的线程会等待执行完
            {
                if(num >= m)
                {
                    num -= m;
                    Debug.Log("剩余:" + num); 
                    return num;
                }
                return 0;
            }
        }
        public void ChangeStart()
        {
            for (int i =0; i < 100; i++)
            {
                ChangeNum(100);
            }
        }
    }
}
