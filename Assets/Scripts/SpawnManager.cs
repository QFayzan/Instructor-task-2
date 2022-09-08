using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject coinPrefab;
    public GameObject lifePrefab;
    public float[] spawnRangeX;
   //public float spawnRangeZ = 1.5f;
    public float spawnDelay = 1.5f;
    public float spawnInterval = 1.5f;
    // y value has to be 0.2 so that objects dont collide with the plane
   //Vector3 spawnPos = new Vector3(-2, 0.2f, 1.5f);
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnCoin", 4.0f, 1.3f);
        InvokeRepeating("SpawnLife", 10.0f, 4.7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(0, spawnRangeX.Length), 0.2f, 1.5f);
            Instantiate(enemyPrefab, new Vector3(spawnRangeX[Random.Range(0,4)] , 0.2f , 1.5f), enemyPrefab.transform.rotation);
        }
             
    }
    void SpawnCoin()
    {
           // Vector3 spawnPos = new Vector3(Random.Range(0, spawnRangeX.Length), 0.2f, 1.5f);
            Instantiate(coinPrefab, new Vector3(spawnRangeX[Random.Range(0, 4)], 0.2f, 1.5f), coinPrefab.transform.rotation);
    }
    void SpawnLife()
    {
            //Vector3 spawnPos = new Vector3(Random.Range(0, spawnRangeX.Length), 0.2f, 1.5f);
            Instantiate(lifePrefab, new Vector3(spawnRangeX[Random.Range(0, 4)], 0.2f, 1.5f), lifePrefab.transform.rotation);
    }
}
