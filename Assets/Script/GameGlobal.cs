using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameGlobal : MonoBehaviour 
{   

	// Use this for initialization
	void Start () 
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            SDKMgr.HideSplash();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
