using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameManager gameManager;
    public Transform[] spawnPoints;
    public GameObject waterDrop;

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public float minTimeBetweenSpawns;

    void Update()
    {
        if (gameManager.isPlaying)
        {
            if (timeBtwSpawns <= 0)
            {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                Instantiate(waterDrop, randomSpawnPoint.position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns -= Time.deltaTime;
            }
        }
    }
}
