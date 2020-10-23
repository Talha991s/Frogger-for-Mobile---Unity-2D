/*
 Filename: Returntomain.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file load the scene to return back to mainmenu
 Revision History:
 28/09/2020
 29/09/2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Returntomain : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene(0);
    }
}
