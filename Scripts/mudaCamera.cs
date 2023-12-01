using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mudaCamera : MonoBehaviour {

    public Camera camera1;
    public Camera camera2;

    private void Start()
    {
        camera2.enabled = false;
    }
    public void AlternarCameras()
    {
        if (camera1.enabled)
        {
            camera1 = Camera.main;
            camera1.enabled = false;
            camera2.enabled = true;
        }
        else
        {
            
            camera1.enabled = true;
            camera2.enabled = false;
        }
    }
}
