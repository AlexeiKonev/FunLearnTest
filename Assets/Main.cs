using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static Main Instance;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject GameWinPanel;
    private void Start()
    {
        Instance = this;
        GameOverPanel.SetActive(false);
        GameWinPanel.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
    }
    public void RestartGame()
    {
        Time.timeScale = 1;
        GameOverPanel.SetActive(false);
        SceneManager.LoadScene(0);
    }
    public void ExitGame()
    {
        Application.Quit();
    }




}
