using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public Transform spawnPosition;
    void Start()
    {
         StartCoroutine(spawnObject());
    }

    private IEnumerator spawnObject()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 6));
            GameObject go = Instantiate(objectsToSpawn[Random.Range(0, 5)], spawnPosition.position, spawnPosition.rotation);
        }
    }
}
