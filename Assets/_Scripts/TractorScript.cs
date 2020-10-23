/*
 Filename: TractorScript.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file determine the movement of the tractor in the scene, things such as 
              the speed, direction.
 Revision History:
 28/09/2020
 29/09/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TractorScript : MonoBehaviour
{
    
    public Rigidbody2D rb;
   // public float boundary;

    [SerializeField]
    float speed = 1.0f;

     float minspeed = 3.0f;
     float maxspeed = 5.0f;

    void Start()
    {
        speed = Random.Range(minspeed,maxspeed);
    }

    // use fix update since we are dealing with Ai and physics
    void FixedUpdate()   
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime* speed);
    }

}
