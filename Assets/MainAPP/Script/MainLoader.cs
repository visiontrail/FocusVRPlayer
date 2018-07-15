using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using wvr;
using UnityEngine.UI;

public class MainLoader : MonoBehaviour {

    public WaveVR_ControllerPointer ViveControler;
    public Link_6DOF_Controller_MultiComponent_Behavior SixDOFControler;
    public Text ShowDebugInfo;

    public void ShowDebugInfoFunc()
    {
        ShowDebugInfo.text = "123";
    }

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}

}
