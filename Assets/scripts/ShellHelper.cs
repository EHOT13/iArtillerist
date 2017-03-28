using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellHelper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject,1);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
