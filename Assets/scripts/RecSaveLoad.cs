using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecSaveLoad
{
    //public int recCurrentArray = new int();List<Records> recs = new List<Records>();
    //List<Records> recCurrentArray = new List<Records>();
    public void Save(int temp)
    {
        PlayerPrefs.SetInt("MainRecord", temp);
        //recCurrentArray.Add(new Records() { recordJ7 = GameManager.score });
        //recCurrentArray.ForEach(delegate (Records temp)
        //{
        //    Debug.Log(temp);
        //});
    }
    public int Load()
    {
        return PlayerPrefs.GetInt("MainRecord");
    }
}