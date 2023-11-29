using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class GameOverLogic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource loseMusic;
    [SerializeField] private HealthPoints playerHealthPoints;
    [SerializeField] private string buttonToMenu = "add level name here";
    [SerializeField] private GameObject FirstButtonSelected;

    private void Update()
    {
        EndLevel();
    }

    public void SetGameOverScreen()
    {
        gameOverMenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }

    public void EndLevel()
    {
        if (playerHealthPoints.health <= 0)
        {
            gameOverMenu.SetActive(true);
            levelMusic.Pause();
        }
    }
}
