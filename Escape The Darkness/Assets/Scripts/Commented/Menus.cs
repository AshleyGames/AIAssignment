using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Above it tells unity that we are using the build settings, and the name of our scenes (sceneManagement) to move beetween scenes
//The UI tells unity that we are using buttons, to make this happen

public class Menus : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Game2");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void HowToPlay2()
    {
        SceneManager.LoadScene("Instructions2");
    }

    public void CreditsMenu()
    {
        SceneManager.LoadScene("Credits");
    }

    public void HighScores()
    {
        SceneManager.LoadScene("LeaderBoard");
    }

    //Above will take the player to the specific scene, depending on what function is called when pressed
}
