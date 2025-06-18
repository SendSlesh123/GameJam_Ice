using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI result;
    [SerializeField] TextMeshProUGUI destroyed;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;

    public void ShowWinPanel(int canDestroy, int destroyed)
    {

        this.destroyed.text = "destroyed " + canDestroy.ToString() + "/" + destroyed.ToString();
        winPanel.SetActive(true);
    }
    public void ShowLosePanel()
    {
        losePanel.SetActive(true);
    }

    public void OnClickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void OnClickNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnClickMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
