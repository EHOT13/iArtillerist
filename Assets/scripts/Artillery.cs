using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Artillery : MonoBehaviour {
    public Transform shell;
    public float power;
    public string stringToEdit = "Degrees here";
    private bool fireButton;
    
    public float degrees;
    public InputField mainInputField;
    public Button fire;
    //----------
    private float nextTime = 0.0F;
    private float timeRate = 3F;
    //----------
    void Start () {
        Time.timeScale = 1;
        Button btn = fire.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        degrees = Convert.ToSingle(mainInputField.text);
    }
    void TaskOnClick()
    {
        fireButton = true;
    }

    // Update is called once per frame
    void Update () {
        try
        {
            if (fireButton == true && Time.time > nextTime)
            {
                fireButton = false;
                degrees = Convert.ToSingle(mainInputField.text);
                GameObject.Find("Stvol").transform.transform.Rotate(0, 0, 0);
                GameObject.Find("Stvol").transform.rotation = Quaternion.identity;
                GameObject.Find("Stvol").transform.transform.Rotate(0, 0, degrees);

                
                Transform BulletInstance = (Transform)Instantiate(shell, GameObject.Find("spawner").transform.position, Quaternion.identity);
                BulletInstance.GetComponent<Rigidbody2D>().AddForce(GameObject.Find("spawner").transform.right * power);
                nextTime = Time.time + timeRate;
                
            }
        }
        catch   (FormatException)
        {
            Debug.Log("Input degrees!");
            
        }

    }
}
