using UnityEngine;
using System.Collections;
using System.IO;

public class ResourceManager : MonoBehaviour {
    private AssetBundle shared;

    void Awake() {
        initialize();
    }
	
    /// <summary>
    /// ��ʼ��
    /// </summary>
    void initialize() {
        byte[] stream;
        string uri = string.Empty;
        //------------------------------------Shared--------------------------------------
        uri = Util.DataPath + "shared.assetbundle";
        Debug.LogWarning("LoadFile::>> " + uri);

        stream = File.ReadAllBytes(uri);
        shared = AssetBundle.CreateFromMemoryImmediate(stream); 
#if UNITY_5
        shared.LoadAsset("Dialog", typeof(GameObject));
#else
        shared.Load("Dialog", typeof(GameObject));
#endif
        ioo.gameManager.OnResourceInited();    //��Դ��ʼ����ɣ��ص���Ϸ��������ִ�к������� 
    }

    /// <summary>
    /// �����ز�
    /// </summary>
    public AssetBundle LoadBundle(string name) {
        byte[] stream = null;
        AssetBundle bundle = null;
        string uri = Util.DataPath + name.ToLower() + ".assetbundle";
        stream = File.ReadAllBytes(uri);
        bundle = AssetBundle.CreateFromMemoryImmediate(stream); //�������ݵ��زİ�
        return bundle;
    }

    /// <summary>
    /// ������Դ
    /// </summary>
    void OnDestroy() {
        if (shared != null) shared.Unload(true);
        Debug.Log("~ResourceManager was destroy!");
    }
}
