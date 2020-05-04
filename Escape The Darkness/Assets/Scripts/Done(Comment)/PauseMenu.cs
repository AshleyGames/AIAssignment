using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public static bool GameControls = false;

    public GameObject PauseMenuCanvas;

    public GameObject ControlsCanvas;

    public GameObject PlayerCanvas;

    void Start()
    {
        PauseMenuCanvas.SetActive(false);
        ControlsCanvas.SetActive(false);
        PlayerCanvas.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }

            else
            {
                PauseGame();
            }
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (GameControls)
            {
                PauseGame();
            }

            else
            {
                ControlsMenu();
            }
        }
    }

    public void Resume()
    {
        PauseMenuCanvas.SetActive(false);
        PlayerCanvas.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void PauseGame()
    {
        PauseMenuCanvas.SetActive(true);
        PlayerCanvas.SetActive(false);
        ControlsCanvas.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameControls = false;
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void ControlsMenu()
    {
        PauseMenuCanvas.SetActive(false);
        PlayerCanvas.SetActive(false);
        ControlsCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameControls = true;
    }
}
