using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject[] treeObjects;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        int randomIndex = Random.Range(0, treeObjects.Length); // random range
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-35, 20), 0, Random.Range(-35, 20)); // spawns in random range coordinates
        Instantiate(treeObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        if (stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
