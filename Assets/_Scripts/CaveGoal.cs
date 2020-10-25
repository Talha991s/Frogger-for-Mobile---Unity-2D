/*
 Filename: CaveGoal.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file detect that the bear reached the cave and update the score.
 Revision History:
 28/09/2020
 29/09/2020
 15/10/2020
 */

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CaveGoal : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("YouWON");
            //ScoreScript.CurrentScore += 100;
           
        }
       // Player.transform.position = respawn.transform.position;
    }


}
