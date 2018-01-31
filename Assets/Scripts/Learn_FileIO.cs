using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;

public class Learn_FileIO : MonoBehaviour {

    public Texture2D m_Texture;

	void Start () {

        //文件夹是否存在判断
        string folder = Application.dataPath + "/Resources/Operation2D";
        if (Directory.Exists(folder))
        {
            Debug.Log("有这个文件夹");
        }
        else
        {
            Directory.CreateDirectory(folder);    //创建一个目录文件夹
        }
        //文件夹删除
        //Directory.Delete(folder);
        
        //文件是否存在判断
        string prefabFile = folder + "/0.prefab";
        if (File.Exists(prefabFile))
        {
            Debug.Log("有这个预制体");
        }
        else
        {
            PrefabUtility.CreateEmptyPrefab("Assets/Resources/Operation2D/" + "0.prefab");   //创建一个预制体
        }
        //文件删除
        //File.Delete(prefabFile);

        //文件写入(设置可读写)
        if (m_Texture == null) return;

        string writePath = "Assets/Resources/Operation2D/" + "/0.png";
        if (System.IO.File.Exists(writePath))
        {
            Debug.Log("有这个Texture");
        }
        else
        {
            System.IO.File.WriteAllBytes(writePath, m_Texture.EncodeToPNG());
        }
        //string streamingPath = Application.streamingAssetsPath + "/0.png";
        //System.IO.File.WriteAllBytes(streamingPath, m_Texture.EncodeToPNG());

        //文件读取(Resources)
        string loadPath = "Operation2D/0.png";
        Texture t0 = Resources.Load(loadPath) as Texture;
        if(t0 != null)
        {
            Debug.Log("Resources里有这个Texture");
        }
        //StartCoroutine(LoadTexture());

    }

    IEnumerator LoadTexture()
    {
        string texturePath = Application.streamingAssetsPath + "/0.png";
        WWW wwwTexture = new WWW(texturePath);

        yield return wwwTexture;

        Texture2D t = wwwTexture.texture;
    }
}
