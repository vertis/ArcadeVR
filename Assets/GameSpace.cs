using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpace : MonoBehaviour {

    public Transform spawner;
    public GameObject templateObject;

    void OnTriggerExit(Collider other)
    {
        // Destroy everything that leaves the trigger
        //Destroy(other.gameObject);
        Debug.Log(spawner.transform.position);
        //other.gameObject.transform.position = spawner.transform.position;
        //other.gameObject.rigidbody.
        Destroy(other.gameObject);
        Instantiate(templateObject, spawner.position, Quaternion.identity);
    }
}
