using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public string MainMenuScene;
    public void QuitShop()
    {
        SceneManager.LoadScene(MainMenuScene);
    }
}
