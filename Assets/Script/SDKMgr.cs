using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class SDKMgr
{
    public static void HideSplash()
    {
        AndroidJavaClass androidClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject mainActivity = androidClass.GetStatic<AndroidJavaObject>("currentActivity");
        mainActivity.Call("HideSplash");

    }
}
