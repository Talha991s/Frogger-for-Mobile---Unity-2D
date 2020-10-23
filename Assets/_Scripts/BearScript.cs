/*
 Filename: BearScript.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file have the player control and trigger the lose scene.
 Revision History:
 27/09/2020 
 28/09/2020
 29/09/2020
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BearScript : MonoBehaviour
{
    public GameObject Lostscene;
    public GameObject Cars;
    public GameObject Police;

   // [SerializeField]
   // Rigidbody2D rb;
   // public static int life = 0;
   // public GameObject Lifes;

    // Update is called once per frame
    void Update()
    {
        // this move the character when the screen is tap

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchposition = Camera.main.ScreenToWorldPoint(touch.position); // converting pixel to the world coordinates.
            touchposition.z = 0;
            transform.position = touchposition;
        }

       /* if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))         I might use this after, if i am adding buttons
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }*/
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "TractorPrefab" || collider.tag == "PolicePrefab")
        {
            Debug.Log("You lost");
            ScoreScript.CurrentScore = 0;
          //  SceneManager.LoadScene(SceneManager.GetActiveScene().name);     //This line reset the scene and set the player to starting point.
            //Lifes.gameObject(DestroyImmediate,life);
            Lostscene.SetActive(true);
            Destroy(gameObject);
            Destroy(Cars);
            Destroy(Police);
        }
    }
}



