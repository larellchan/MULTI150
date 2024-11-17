using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    // Start is called before the first frame update
    private int count = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sphere"))
        {
            count++;
            Debug.Log("Collision count: " + count);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
