using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class GameOverLogic : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;
    [SerializeField] private AudioSource loseMusic;
    [SerializeField] private string buttonToMenu = "add level name here";
    //[SerializeField] private GameObject primerBotonEnElMenu;

    public void SetGameOverScreen()
    {
        gameOverMenu.SetActive(true);
        //var eventSystem = EventSystem.current;
        //eventSystem.SetSelectedGameObject(primerBotonEnElMenu, new BaseEventData(eventSystem));
        //Debug.Log("Current selected GameObject : " + eventSystem.currentSelectedGameObject);
        loseMusic.Play();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(buttonToMenu);
    }
}
