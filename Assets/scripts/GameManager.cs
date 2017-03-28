using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public Text pointsText;
    public static int score = 0;
    // Use this for initialization
    void Start () {
		
	}
    // Update is called once per frame
    void Update () {
        pointsText.text = "Score: "+score;
	}
}
