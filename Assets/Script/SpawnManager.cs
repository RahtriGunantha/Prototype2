using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // public int animalIndex;
    public float randomSpawnX = 20;
    public float randomSpawnZ = 20;
    private float spawnTime = 2;
    private float spawnDelay = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
    void SpawnRandomAnimals()
    {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-randomSpawnX, randomSpawnX),0,randomSpawnZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
