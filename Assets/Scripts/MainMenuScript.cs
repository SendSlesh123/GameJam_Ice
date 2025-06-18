using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public void OnClickStart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
