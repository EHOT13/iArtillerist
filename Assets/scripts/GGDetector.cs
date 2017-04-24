using System;
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
    //public static List<Records> recs = new List<Records>();
    public static int[] leaderBoard = new int[5];
    void Start () {
        _TextGG.gameObject.SetActive(false);
        _ButtonAgain.gameObject.SetActive(false);
    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tiger")
        {
            _TextGG.gameObject.SetActive(true);
            _ButtonAgain.gameObject.SetActive(true);
            Time.timeScale = 0;
            if (PlayerPrefs.GetInt("MainRecord") < GameManager.score)
            {
                RecSaveLoad save = new RecSaveLoad();
                save.Save(GameManager.score);
            }
        }        
    }
    // Update is called once per frame

    void Update () {
		
	}
}
