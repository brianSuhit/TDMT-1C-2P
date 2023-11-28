using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class GameOverLogic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource loseMusic;
    [SerializeField] private HealthPoints healthPoints;
    [SerializeField] private string buttonToMenu = "add level name here";

    [SerializeField] private GameObject newFirstSelectedButton;
    [SerializeField] private GameObject newSecondSelectedButton;

    private void Update()
    {
        EndLevel();
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(newFirstSelectedButton, new BaseEventData(eventSystem));
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
            var eventSystem = EventSystem.current;
            eventSystem.SetSelectedGameObject(newSecondSelectedButton, new BaseEventData(eventSystem));
            levelMusic.Pause();
        }
    }
}
