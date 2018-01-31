using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Learn_Sort_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameLight am = new GameLight(5,"haha",5.5f);
        GameLight bm = new GameLight(9, "haha", 5.9f);
        GameLight cm = new GameLight(6, "hehe", 5.6f);
        GameLight dm = new GameLight(7, "haha", 5.7f);

        //对象排序
        List<GameLight> gl = new List<GameLight>() { am, bm, cm ,dm};
        gl.Sort(delegate (GameLight m, GameLight n) { return m.c.CompareTo(n.c); });
        for(int i=0;i<gl.Count;i++)
        {
            Debug.Log(gl[i].c);
        }


        //实现了接口的排序
        List<int> gintl = new List<int>() { 1, 3, 4 ,9,6};
        gintl.Sort((x, y) => x.CompareTo(y));
        for (int i = 0; i < gintl.Count; i++)
        {
            Debug.Log(gintl[i]);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
class GameLight
{
    public int a;
    public string b;
    public float c; 

    public GameLight(int _a,string _b,float _c)
    {
        a = _a;
        b = _b;
        c = _c;
    }

}
