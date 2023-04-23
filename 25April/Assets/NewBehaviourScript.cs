using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        OnDestroy(GetComponent<BoxCollider>());
        gameObject.tag = "changed";
        if (gameObject.tag == "changed")
        {
            gameObject.name = "changed";
            Destroy(GetComponent<NewBehaviourScript>());
        }
    }

    public  void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "plane")
        {
            Debug.Log("hit the plane");
        }
    }
    private void OnEnable()
    {  
        enabled = true;
    }
    private void OnDestroy(BoxCollider boxCollider)
    {
        enabled = false; 
    }

   
}
