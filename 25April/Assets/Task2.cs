using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("start game");
    }
    void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.name="Empty";
        collision.transform.parent = transform; 
    }

    void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().enabled=false;
    }
    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent <Renderer>().enabled=true;
        other.gameObject.tag = "entered";
    }

}
