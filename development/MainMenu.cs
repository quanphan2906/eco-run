using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string playGameLevel;
    public string shopScene;

    public void PlayGame()
    {
        SceneManager.LoadScene(playGameLevel);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void OpenShop()
    {
        SceneManager.LoadScene(shopScene);
    }
}
