/*
Filename: PolicePool.cs
Author: Salick Talhah
Student Number: 101214166
Date last modified: 15/10/2020
Description: This file determine the spawning locations of the police by using an array and the time, delay to spawn a new object.
Revision History:
15/10/2020
22/10/2020
*/

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Lifecontroller : MonoBehaviour
{
     public GameObject Life1, Life2, life3;
    public static int Life;
    public GameObject Lostscene;
    public GameObject Cars;
    public GameObject Police;
    public GameObject boat;
    public GameObject player;
    //public GameObject player;

    //public GameObject Lostscene;
    // Start is called before the first frame update
    void Start()
    {
        Life = 3;
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        if (Life > 3)
        {
            Life = 3;
        }
        switch (Life)
        {
            case 3:
                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                Lostscene.SetActive(false);
                //ScoreScript.CurrentScore += 100;
                // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case 2:
                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                Lostscene.SetActive(false);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case 1:
                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                Lostscene.SetActive(false);
                //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                break;
            case 0:
                Life1.gameObject.SetActive(false);
                Life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                Lostscene.SetActive(true);
                Destroy(gameObject);
                Destroy(Cars);
                Destroy(boat);
                Destroy(Police);
                Destroy(player);
                break;
        }
    }
}
