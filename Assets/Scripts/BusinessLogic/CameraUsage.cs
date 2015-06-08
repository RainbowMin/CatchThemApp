/********************************************************************
	created:	2015/6/8
	filename: 	CameraUsage
	author:		Rainbow	
	purpose:	
*********************************************************************/
using UnityEngine;
using System.Collections;

public class CameraUsage : MonoBehaviour 
{
    public string _DeviceName;//这个虽然public，但无需为其绑定变量，直接运行，默认调用，显示本地摄像机的名称
    WebCamTexture _WebCam;

	void Start () 
	{
        StartCoroutine(WebCam_Play());
	}

    IEnumerator WebCam_Play()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);

        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            WebCamDevice[] devices = WebCamTexture.devices;
            _DeviceName = devices[0].name;
            _WebCam = new WebCamTexture(_DeviceName, 400, 300, 12);
            renderer.material.mainTexture = _WebCam;

            _WebCam.Play();
        }
    }

    //void Update()
    //{
    //    MeshRenderer renderer = this.GetComponent<MeshRenderer>();
    //    renderer.material.mainTexture = _WebCam;
    //}
}
