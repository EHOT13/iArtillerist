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
    private float hSliderValue = 0.0f;
    public float degrees;
    //void OnGUI()
    //{
    //    //hSliderValue = GUI.HorizontalSlider(new Rect(25, 50, 100, 30), hSliderValue, 0.0f, 10.0f);
    //    stringToEdit = GUI.TextField(new Rect(10, 10, 200, 20), stringToEdit, 25);
    //    if (GUI.Button(new Rect(10, 35, 200, 20), "Button"))
    //    {
    //        fireButton = true;
    //    }
    //    if (GUI.Button(new Rect(10, 65, 200, 20), "Exit"))
    //    {
    //        Application.Quit(); 
    //    }

    //}
    public InputField mainInputField;
    public Button fire;
    // Use this for initialization
    void Start () {
        Button btn = fire.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        //degrees = Convert.ToSingle(stringToEdit);
        //GameObject.Find("Stvol").transform.transform.Rotate(0, 0, degrees);
        degrees = Convert.ToSingle(mainInputField.text);
    }
    void TaskOnClick()
    {
        fireButton = true;
    }

    // Update is called once per frame
    void Update () {

        if (fireButton == true)
        {
            degrees = Convert.ToSingle(mainInputField.text);
            GameObject.Find("Stvol").transform.transform.Rotate(0, 0, 0);
            //try
            //{
            //    degrees = Convert.ToSingle(stringToEdit);
            //}
            //catch (FormatException)
            //{
            //    //GUI.Label(new Rect(10, 10, 100, 20), "Incorrect degrees");
            //    Debug.Log("Incorrect degrees");
            //}

            GameObject.Find("Stvol").transform.rotation = Quaternion.identity;
            GameObject.Find("Stvol").transform.transform.Rotate(0, 0, degrees);


            fireButton = false;
            //TODO: Удалить клоны шела
            Transform BulletInstance = (Transform)Instantiate(shell, GameObject.Find("spawner").transform.position, Quaternion.identity);
            //BulletInstance.GetComponent<Rigidbody2D>().AddForce(gameObject.transform.right * power);
            BulletInstance.GetComponent<Rigidbody2D>().AddForce(GameObject.Find("spawner").transform.right * power);


        }

    }
}
