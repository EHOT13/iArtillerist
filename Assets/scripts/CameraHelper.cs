using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        if (Screen.width < 1366)
        {
            Camera.main.orthographicSize = 7;
        }
    }
	
	// Update is called once per frame
	void Update () {
      

    }
}
