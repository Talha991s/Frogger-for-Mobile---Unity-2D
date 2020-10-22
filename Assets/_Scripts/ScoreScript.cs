/*
 Filename: ScoreScript.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file update the score everytime the bear reach a cave.
 Revision History:
 28/09/2020
 29/09/2020
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public static int CurrentScore = 0;  // this make the score to remain static even when you leave the game

    public Text ScoreText;
    
    // updating the string referring to the score
    void Start()
    {
        ScoreText.text = CurrentScore.ToString();
    }

}
