using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void onTriggerEnter (Collider other)
    {
        print(other.gameObject.name + " has entered the cube");
    }
    void OnTriggerStay (Collider other )
    {
        print(other.gameObject.name + " is still in the cube");
    }
    void onTriggerExit (Collider other)
    {
        print(other.gameObject.name + "has left the cube");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
