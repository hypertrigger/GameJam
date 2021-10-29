using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool gameIsPaused = false;

    public void Start()
    {
        pauseMenu.SetActive(false);
        gameIsPaused = false;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScreen");
        Time.timeScale = 1;
        print("GAME SCREEN");
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("MenuScreen");
        print("MENU SCREEN");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        if (gameIsPaused)
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            print("GAME IS PAUSED");
        }
        else
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            print("GAME ON!!");
        }
    }
}
