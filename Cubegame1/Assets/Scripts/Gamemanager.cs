﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{

    bool gamehasEnded = false;

    public float restartDelay = 1f;

    public void EndGame()
    {
        if (gamehasEnded == false)
        {

            gamehasEnded = true;
            Debug.Log("Game Over"); //restart game
            Invoke("Restart", restartDelay);
        }
    }

      void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
