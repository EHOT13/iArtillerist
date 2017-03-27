using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHelper : MonoBehaviour {
    public float scrollSpeed = 0.5f;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)==true)
        {
            Camera.main.orthographicSize += scrollSpeed;
        }
       
    }
}
