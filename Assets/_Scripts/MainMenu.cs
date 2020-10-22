/*
 Filename: MainMenu.cs
 Author: Salick Talhah
 Student Number: 101214166
 Date last modified: 29/09/2020
 Description: This file load the playscene and have the function for the buttons in the Mainmenu.
 Revision History:
 28/09/2020
 29/09/2020
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //main menu function
    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
