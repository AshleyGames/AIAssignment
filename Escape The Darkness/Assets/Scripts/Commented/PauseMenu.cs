using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    //This says to start with that they are falsed as when the game is first played, its not paused
    public static bool GameIsPaused = false;
    public static bool GameControls = false;

    //These three public gameObjects are for the different canavases that are on the game scene.
    //They were each dragged and dropped for their specfic canvas
    public GameObject PauseMenuCanvas;
    public GameObject ControlsCanvas;
    public GameObject PlayerCanvas;

    //At the start of the game only the player canvas is visablly, the other two are hidden
    void Start()
    {
        PauseMenuCanvas.SetActive(false);
        ControlsCanvas.SetActive(false);
        PlayerCanvas.SetActive(true);

    }

   //Below is saying if either key P is pressed and the game is paused 
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            //Do this

            else
            {
                PauseGame();
            }
            //if not then do this
        }
        //Below is saying if either key C is pressed and the game isn't paused 
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (GameControls)
            {
                PauseGame();
            }
            //do this

            else
            {
                ControlsMenu();
            }
            //if it is paused then do this
        }
    }
    //This tell unity what canvas is active or not, when the button is pressed
    //Its also allows everything to unfreeze
    public void Resume()
    {
        PauseMenuCanvas.SetActive(false);
        PlayerCanvas.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //This tell unity what canvas is active or not, when the button is pressed
    //Its also allows everything to freeze
    public void PauseGame()
    {
        PauseMenuCanvas.SetActive(true);
        PlayerCanvas.SetActive(false);
        ControlsCanvas.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
        GameControls = false;
    }

    //This tell unity to change scenes when the button is pressed
    //Its also allows the menu to unfreeze
    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    //This tell unity what canvas is active or not, when the button is pressed
    //Its also allows everything to freeze
    public void ControlsMenu()
    {
        PauseMenuCanvas.SetActive(false);
        PlayerCanvas.SetActive(false);
        ControlsCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameControls = true;
    }
}
