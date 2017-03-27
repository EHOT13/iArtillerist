using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTigers : MonoBehaviour {
    public Transform tiger;
    public int tigerCounter;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //TODO: Поиск по тегу и спаун если таких объектов нет
		if (GameObject.Find("Tiger(Clone)") == false)
        {
            Transform TigerInstance = Instantiate(tiger, GameObject.Find("TigerSpawner").transform.position, Quaternion.identity);
        }
	}
}
