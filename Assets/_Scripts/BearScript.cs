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
 22/10/2020
 23/10/2020
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BearScript : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnpoint;

    public GameObject Lostscene;


    //public float maxSpeed;
    public static int CurrentScore = 0;
    public Text ScoreText;
   
    //public float verticalSpeed;
    //public float HorizontalSpeed;
    //public float HorizontalTValue;
    //public float VerticalTValue;

    private Rigidbody2D m_rigidBody;
    private Vector3 m_touchesEnded;
    void Start()
    {
        //setting the touch 
        m_touchesEnded = new Vector3();
        m_rigidBody = GetComponent<Rigidbody2D>();
        ScoreText.text = CurrentScore.ToString();
    
    //life thing
    }
        

    // Update is called once per frame
    void Update()
    {
        //_Move();
        // this move the character when the screen is tap
        // this move the character when the screen is tap

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchposition = Camera.main.ScreenToWorldPoint(touch.position); // converting pixel to the world coordinates.
            touchposition.z = 0;
            transform.position = touchposition;
        }

    }

    //void _Move()
    //{
    //    float direction = 0.0f;

    //    //touch input support
    //    foreach (var touch in Input.touches)
    //    {
    //        var worldTouch = Camera.main.ScreenToWorldPoint(touch.position);
    //        if (worldTouch.y > transform.position.y || worldTouch.x > transform.position.x)
    //        {
    //            direction = 1.0f;
    //        }

    //        if (worldTouch.y < transform.position.y || worldTouch.x < transform.position.x)
    //        {
    //            direction = -1.0f;
    //        }
    //        m_touchesEnded = worldTouch;
    //    }

    //    // keyboard support
    //    if (Input.GetAxis("Vertical") >= 0.1f)
    //    {
    //        // direction is positive ---> UP
    //        direction = 1.0f;
    //    }

    //    if (Input.GetAxis("Vertical") <= -0.1f)
    //    {
    //        // direction is negative---> Down
    //        direction = -1.0f;
    //    }

    //    if (m_touchesEnded.y != 0.0f)
    //    {
    //        // move on y axis depending of the value of unit per touch.
    //        transform.position = new Vector2(Mathf.Lerp(transform.position.x, m_touchesEnded.x, HorizontalTValue), Mathf.Lerp(transform.position.y, m_touchesEnded.y, VerticalTValue));
    //    }
    //    else
    //    {
    //        Vector2 newVelocity = m_rigidBody.velocity + new Vector2(0.0f, direction * verticalSpeed);
    //        m_rigidBody.velocity = Vector2.ClampMagnitude(newVelocity, maxSpeed);
    //        m_rigidBody.velocity *= 0.99f;
    //    }

    //}

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "GoalPrefab")
        {
            CurrentScore += 50;
            //Player.transform.position = respawnpoint.transform.position;
            Debug.Log("Score " + CurrentScore);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if(collider.tag == "TractorPrefab" || collider.tag == "PolicePrefab" || collider.tag == "BoatPrefab")
        {
            Debug.Log("You lost");
            CurrentScore =0;

            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);     //This line reset the scene and set the player to starting point.
            //Lifes.gameObject(DestroyImmediate,life);
            //player.SetActive(true);
            Lifecontroller.Life -= 1;
           // Destroy(gameObject);
            //Destroy(Cars);
            //Destroy(Police);
            //Destroy(boat);
            //AudioClip();
            Player.transform.position = respawnpoint.transform.position;
        }
           
       // player.SetActive(true);
    }
}



