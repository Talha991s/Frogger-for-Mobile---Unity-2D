/*
 Filename: PoliceCar.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 15/10/2020
 Description: This file determine the movement of the Police car in the scene, things such as 
              the speed, direction.
 Revision History:
 15/10/2020
 22/10/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceCar : MonoBehaviour
{
    public Rigidbody2D rb2;
    //public float boundary;


    [SerializeField]
    float speed = 1.0f;

     float minspeed = 1.5f;
     float maxspeed = 3.0f;

    void Start()
    {
        // the speed of the car will be randomized in this range
        speed = Random.Range(minspeed, maxspeed);
    }
    //void Update()
    //{
    //    _CheckBound();
    //}
    // use fix update since we are dealing with AI and physics
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb2.MovePosition(rb2.position + forward * Time.fixedDeltaTime * speed);
    }
    //public void _CheckBound()
    //{
    //    if(transform.position.x > boundary)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

}
