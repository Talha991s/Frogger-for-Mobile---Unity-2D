/*
 Filename: CaveGoal.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file detect that the bear reached the cave and update the score.
 Revision History:
 28/09/2020
 29/09/2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaveGoal : MonoBehaviour
{
    private void OnTriggerEnter2D()
    {
        Debug.Log("you WOn");
        ScoreScript.CurrentScore += 100;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
