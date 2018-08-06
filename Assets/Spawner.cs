using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject templateObject;
    public float xMin;
    public float xMax;
    public int numOfBalls;
    public float timeMin;
    public float timeMax;


    void Start()
    {
        for (int i = 0; i < numOfBalls; i++)
        {
            Invoke("SpawnBasketball", Random.Range(timeMin, timeMax));

        }
    }


    void SpawnBasketball() {
        float xRand = Random.Range(transform.position.x-xMin, transform.position.z-xMax);
        Vector3 pos = new Vector3(xRand, 1.0f, transform.position.z);
        Debug.Log(pos);
        Instantiate(templateObject, pos, Quaternion.identity);
    }

    // Update is called once per frame
    //void Update () {
       // Instantiate(templateObject);
    //}
}
