using UnityEngine;
using System.Collections;
public class Learn_event : MonoBehaviour {
	void Start () {
        Sample.SampleEvent += sim;                        // += 订阅事件
        Sample.SampleEvent_CallBack();                    //会先执行Sample里面的方法，再执行sim
	}
    void sim(eventClass s)
    {
        Debug.Log("灵活的");
    }
    void Destroy()
    { 
        Sample.SampleEvent -= sim; 
    }
}
public class Sample
{
    public delegate void SampleEventHandle(eventClass e);
    public static event SampleEventHandle SampleEvent;
    public static void SampleEvent_CallBack()
    {
        if (SampleEvent != null)
        {
            SampleEvent(new eventClass("Hello"));
        }
    }
}
public class eventClass
{
    public string _s
    {
        get;
        private set;
    }
    public eventClass(string s) 
    { 
        _s = s;
        Debug.Log("SetMethod");
    }
}