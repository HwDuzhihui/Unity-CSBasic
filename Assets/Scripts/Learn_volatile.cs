using UnityEngine;
using System.Collections;
using System.Threading;

public class Learn_volatile : MonoBehaviour {

    //编译器在优化代码时，可能会把经常用到的代码存在Cache里面，然后下一次调用就直接读取Cache而不是内存,
    //这样就大大提高了效率。但是问题也随之而来了。

    //在多线程程序中，如果把一个变量放入Cache后，又有其他线程改变了变量的值，那么本线程是无法知道这个变化的。
    //它可能会直接读Cache里的数据。但是很不幸，Cache里的数据已经过期了，读出来的是不合时宜的脏数据。这时就会出现bug。

    //用Volatile声明变量可以解决这个问题。用Volatile声明的变量就相当于告诉编译器，我不要把这个变量写Cache，
    //因为这个变量是可能发生改变的。
	void Start () {
        WorkClass workC = new WorkClass();
        Thread workThread = new Thread(workC.DoWork);

        workThread.Start();
        Debug.Log("Main Thread: worker thread start");

        while (!workThread.IsAlive) ;    //IsAlive，如果线程已启动且未终止返回true

        Thread.Sleep(1);

        workC.RequestStop();

        workThread.Join();
        Debug.Log("Main Thread: worker thread stop");
	}
}
class WorkClass
{
    private  volatile bool shouldStop;
    public void RequestStop()
    {
        shouldStop = true;
    }
    public void DoWork()
    {
        while(!shouldStop)
        {
            Debug.Log("Worker thread: working");
        }
        Debug.Log("Worker Thread: stop");
    }
}
class VolatileClass
{
    public volatile int i;
    public void SetVolatile(int _i)
    {
        i = _i;
    }
}
