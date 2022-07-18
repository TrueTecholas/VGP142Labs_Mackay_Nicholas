using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollectableSpawn : MonoBehaviour
{
    int randCollectable = 0;

    public GameObject speedPrefab;
    public GameObject healthPrefab;
    public GameObject shieldPrefab;
    public GameObject damagePrefab;

    public Transform spawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        float randomNumber = Random.Range(0, 4);

         switch (randomNumber)
            {
                case 0:
                    GameObject speedpowerup = Instantiate(speedPrefab, spawnPoint.position, spawnPoint.rotation);
                    break;

                case 1:
                    GameObject healthpowerup = Instantiate(healthPrefab, spawnPoint.position, spawnPoint.rotation);
                    break;

                case 2:
                    GameObject shieldpowerup = Instantiate(shieldPrefab, spawnPoint.position, spawnPoint.rotation);
                    break;

                case 3:
                    GameObject damagepowerup = Instantiate(damagePrefab, spawnPoint.position, spawnPoint.rotation);
                    break;
             

            }
        




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
