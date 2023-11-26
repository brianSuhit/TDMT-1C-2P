using UnityEngine;
using UnityEngine.SceneManagement;


public class GameOverLogic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource loseMusic;
    [SerializeField] private HealthPoints healthPoints;
    [SerializeField] private string buttonToMenu = "add level name here";

    private void Awake()
    {
        loseMusic.Play();
    }

    private void Update()
    {
        EndLevel();
    }
    public void ReturnButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }

    public void EndLevel()
    {
        if (healthPoints.health <= 0)
        {
            gameOverMenu.SetActive(true);
            levelMusic.Pause();
        }
    }
}
