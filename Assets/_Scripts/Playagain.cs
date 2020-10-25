/*
 Filename: Playagain.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file load the scene to play again.
 Revision History:
 28/09/2020
 29/09/2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playagain : MonoBehaviour
{
    public void Onclick()
    {
        SceneManager.LoadScene(1);
    }
}
