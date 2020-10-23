/*
 Filename: TractorSpawner.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file determine the spawning locations of the tractors by using an array and the time, delay to spawn a new object.
 Revision History:
 28/09/2020
 29/09/2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorSpawner : MonoBehaviour
{

    public GameObject TractorPrefab;
    
    public float spawnDelay =0.3f;

    float nexttimeTospawn = 0.0f;

    public Transform[] Spawpoints;  // the array of spawnpoint to render different Tractors on different lanes

    
    void Update()
    {
        if (nexttimeTospawn <= Time.time)
        {
            SpawnTractor();
            nexttimeTospawn = Time.time + (spawnDelay * 2); // determine when to spawn the next tractor

        }
    }
        
    void SpawnTractor()
    {
        // we get a random number in the array at a random spawn point using an Index

        int RandomIndex = Random.Range(0, Spawpoints.Length);
        Transform Spawpoint = Spawpoints[RandomIndex];
        
        Instantiate(TractorPrefab, Spawpoint.position, Spawpoint.rotation);

    }
   

}


