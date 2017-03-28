using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerMove : MonoBehaviour {
    public int hp;
    public float speed;
    
    // Use this for initialization
    void Start () {
        hp = 3;
        speed = 0.9f;
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.rigidbody)
        //{
        //    Debug.Log("col tag: " + collision.tag);
        //    Debug.Log("GO tag: " + collision.gameObject.tag);
        //}
        if (collision.collider.tag == "Shell")
        {
            hp -= 1;
        }
    }
    
    
    // Update is called once per frame
    void Update () {
		GameObject.Find("Tiger(Clone)").transform.Translate(Vector3.left * Time.deltaTime * speed);
        if (hp<=0)
        {
            Destroy(gameObject);
            GameManager.score += 1;
        }
    }
}
