using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour {
    public Text firstLine;
    public Text secondLine;
    public Text thirdLine;
    public Text fouthLine;
    public Text fifthLine;
    
    void Start () {
        
        RecSaveLoad load = new RecSaveLoad();
        firstLine.text =  Convert.ToString(load.Load());
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
