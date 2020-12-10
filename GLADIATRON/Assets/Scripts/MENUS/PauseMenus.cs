using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PauseMenus : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if (GameIsPaused)
        {
            Pause();
        }
       
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);

        GameIsPaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);

        GameIsPaused = true;
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
