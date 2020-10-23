/*
 Filename: BoatScript.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 15/10/2020
 Description: This file determine the movement of the boats in the scene, things such as 
              the speed, direction.
 Revision History:
 15/10/2020
 22/10/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatScript : MonoBehaviour
{
    public Rigidbody2D rb3;

    [SerializeField]
    float speed = 1.0f;

    float minspeed = 0.5f;
    float maxspeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(minspeed, maxspeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb3.MovePosition(rb3.position + forward * Time.fixedDeltaTime * speed);
    }
}
