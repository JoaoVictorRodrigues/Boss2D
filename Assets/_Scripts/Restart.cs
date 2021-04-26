﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Start(){
       
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.M)){
            SceneManager.LoadScene("Menu");
            Time.timeScale = 1f;
        }
    }
    public void MainMenu(){
        SceneManager.LoadScene("Menu");
    }
}
