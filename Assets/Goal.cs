using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public Text scoreText;
    int score = 0;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello " + gameObject.name);
        
	}

    //void OnCollisionEnter(Collision col)
    //{
    //    Debug.Log("Collision " + gameObject.name);
    //    Destroy(col.contacts[0].otherCollider.gameObject);
    //}

    void OnTriggerEnter(Collider other)
    {
        //Destroy(other.gameObject);
        score++;
        //Debug.Log("Goal " + score);
        scoreText.text = score.ToString();
    }
}
