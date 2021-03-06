﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    private const float xRange = 10.0f;
    private const float spawnPointZ = 25.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimals", 3.0f, 1.5f);
    }

    // Update is called once per frame
    //randimal stands for random animal
    void Update()
    {
        
    }

    void SpawnAnimals()
    {
        int randimal = Random.Range(0, animals.Length);
        Instantiate(animals[randimal], new Vector3(Random.Range(-xRange, xRange), 0f, spawnPointZ),
        animals[randimal].transform.rotation);
    }
}
