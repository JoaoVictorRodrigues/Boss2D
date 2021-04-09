using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    GameManager gm;

    void Start(){
        gm = GameManager.GetInstance();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gm.gameState == GameManager.GameState.END){
            gm.changeState(GameManager.GameState.GAME);
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
