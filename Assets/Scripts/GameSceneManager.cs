using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    // To start Game
    public void StartGame()
    {
        SceneManager.LoadScene("GameView");
        SceneManager.UnloadSceneAsync("MainPageUI");
    }

    // To Go to Home
    public void GoToHome()
    {
        SceneManager.LoadScene("MainPageUI");
        SceneManager.UnloadSceneAsync("GameView");
    }

    // To Quit Game
    public void QuitGame()
    {
        Application.Quit();
    }
}
