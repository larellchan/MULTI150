using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject powerupPrefab;
    public GameObject obstaclePrefab;
    public GameObject hammerPrefab; 
    public float spawnCycle = 0.5f;

    private GameManager manager;
    private float elapsedTime;
    private int spawnCounter = 0; 

    // Start is called before the first frame update
    void Start()
    {
        manager = GetComponent<GameManager>();
        if (manager == null)
        {
            Debug.LogError("GameManager component not found on the GameObject!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime > spawnCycle)
        {
            GameObject temp = null;

            
            switch (spawnCounter % 3) 
            {
                case 0:
                    temp = Instantiate(powerupPrefab);
                    break;
                case 1:
                    temp = Instantiate(obstaclePrefab);
                    break;
                case 2:
                    temp = Instantiate(hammerPrefab);
                    break;
            }

            
            if (temp != null)
            {
                Vector3 position = temp.transform.position;
                position.x = Random.Range(-3f, 3f);
                temp.transform.position = position;

                Collidable col = temp.GetComponent<Collidable>();
                if (col != null)
                {
                    col.manager = manager;
                }
            }

            elapsedTime = 0;
            spawnCounter++;
        }
    }
}
