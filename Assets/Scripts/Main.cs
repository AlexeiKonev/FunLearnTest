using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static Main Instance;
    public Shoot Shoot;
    [SerializeField] private GameObject GameOverPanel;
    [SerializeField] private GameObject GameWinPanel;
    [SerializeField] private GameObject GameMenuPanel;
    [SerializeField] private bool GameMenuPanelIsActive;
    private void Start()
    {
        Shoot = GetComponent<Shoot>();
        Instance = this;
        GameOverPanel.SetActive(false);
        GameWinPanel.SetActive(false);
        GameMenuPanel.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            GameMenu();
        }
    }
    public void GameMenu()
    {
        if (!GameMenuPanelIsActive)
        {
            Time.timeScale = 0;
            GameMenuPanel.SetActive(true);
            GameMenuPanelIsActive = true;
        }
        else
        {
            GameMenuPanel.SetActive(false);
            Time.timeScale = 1;
            GameMenuPanelIsActive = false;
        }

    }
    public void GameWin()
    {
        Time.timeScale = 0;
        GameWinPanel.SetActive(true);
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
