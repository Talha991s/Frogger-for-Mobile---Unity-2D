/*
Filename: PolicePool.cs
Author: Salick Talhah
Student Number: 101214166
Date last modified: 15/10/2020
Description: This file determine the spawning locations of the police by using an array and the time, delay to spawn a new object.
Revision History:
15/10/2020
20/10/2020
22/10/2020
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPool : MonoBehaviour
{
    public GameObject PolicePrefab;
    public float spawnDelay = 0.3f;
    float nextTimeSpawn = 0.0f;
    public Transform[] Spawpoints;
    // Update is called once per frame
    void Update()
    {
        if (nextTimeSpawn <= Time.time)
        {
            SpawnPolice();
            nextTimeSpawn = Time.time + (spawnDelay * 3.5f);
        }
    }

    void SpawnPolice()
    {
        int RandomIndex = Random.Range(0, Spawpoints.Length);
        Transform Spawnpoint = Spawpoints[RandomIndex];
        Instantiate(PolicePrefab, Spawnpoint.position, Spawnpoint.rotation);
    }
}

