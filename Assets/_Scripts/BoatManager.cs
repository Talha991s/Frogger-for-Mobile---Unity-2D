/*
Filename: PolicePool.cs
Author: Salick Talhah
Student Number: 101214166
Date last modified: 15/10/2020
Description: This file determine the spawning locations of the boat by using an array and the time, delay to spawn a new object.
Revision History:
15/10/2020
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatManager : MonoBehaviour
{
    public GameObject BoatPrefab;

    public float spawndelay = 0.5f;

    float nexttospawn = 0.0f;

    public Transform[] Spawnpoints;


    // Update is called once per frame
    void Update()
    {
        if (nexttospawn <= Time.time)
        {
            SpawnBoat();
            nexttospawn = Time.time + (spawndelay * 4);
        }
    }

    void SpawnBoat()
    {
        int RandomIndex = Random.Range(0, Spawnpoints.Length);
        Transform spawnpoint = Spawnpoints[RandomIndex];

        Instantiate(BoatPrefab, spawnpoint.position, spawnpoint.rotation);
    }
}
