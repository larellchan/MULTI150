using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject KamurochoPrefab;
    public Vector3 startPosition = new Vector3(0, 0, 0);
    public float spacing = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        int maxOfPrefab = 10;
        for (int i=0; i<maxOfPrefab;i++)
        {
            Vector3 position = startPosition + new Vector3(0, 0, i * spacing);
           Instantiate(KamurochoPrefab, position, Quaternion.identity);
        }
    }

            
   


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(KamurochoPrefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(KamurochoPrefab, transform.position, transform.rotation);
        }
    }
}
