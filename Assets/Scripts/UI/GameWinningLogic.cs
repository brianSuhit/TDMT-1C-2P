using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameWinningLogic : MonoBehaviour
{
    [SerializeField] private GameObject gameWinningMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private AudioSource WinningMusic;
    [SerializeField] private HealthPoints bossHealthPoints;
    [SerializeField] private string buttonToMenu = "add level name here";
    [SerializeField] private string buttonToResetGame = "add level name here";
    [SerializeField] private GameObject FirstButtonSelected;


    private void Update()
    {
        EndLevel();
    }

    public void ReturnButton()
    {
        SceneManager.LoadScene(buttonToResetGame);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(FirstButtonSelected, new BaseEventData(eventSystem));
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }

    public void EndLevel()
    {
        if (bossHealthPoints.health <= 0)
        {
            gameWinningMenu.SetActive(true);
            levelMusic.Pause();
        }
    }
}
