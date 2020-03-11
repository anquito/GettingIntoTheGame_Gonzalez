using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private const float spawnLimitXLeft = -22.0f;
    private const float spawnLimitXRight = 7.0f;
    private float spawnPosY = 30.0f;

    private float startDelay = 1.0f;
    //private float spawnInterval = 4.0f;
    private float spawnIntervalMin = 3.0f;
    private float spawnIntervalMax = 5.0f;
    private float randomInterval;

    // Start is called before the first frame update
    void Start()
    {
        float randomInterval = (Random.Range(spawnIntervalMin, spawnIntervalMax));
        InvokeRepeating("SpawnRandomBall", startDelay, randomInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int randomBall = Random.Range(0, ballPrefabs.Length);

        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[randomBall], spawnPos, ballPrefabs[randomBall].transform.rotation);
    }

}
