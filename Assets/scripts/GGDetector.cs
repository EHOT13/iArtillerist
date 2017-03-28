using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GGDetector : MonoBehaviour {
    // Use this for initialization
    [SerializeField]
    private Text _TextGG;
    [SerializeField]
    private Button _ButtonAgain;

    void Start () {
        _TextGG.gameObject.SetActive(false);
        _ButtonAgain.gameObject.SetActive(false);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Time.timeScale = 0;
    //    Debug.Log("GG");
    //} 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tiger")
        {
            _TextGG.gameObject.SetActive(true);
            _ButtonAgain.gameObject.SetActive(true);
            //_ButtonAgain.onClick
            Time.timeScale = 0;
            //GameObject.FindGameObjectsWithTag("gg
}
        
    }
    // Update is called once per frame

    void Update () {
		
	}
}
