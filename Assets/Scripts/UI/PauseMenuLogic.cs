using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private string buttonToMenu = "add level name here";

    [SerializeField] private GameObject newFirstSelectedButton;
    [SerializeField] private GameObject newSecondSelectedButton;


    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        levelMusic.Pause();
        Time.timeScale = 0f;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(newFirstSelectedButton, new BaseEventData(eventSystem));
    }

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        levelMusic.Play();
        Time.timeScale = 1f;
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(newSecondSelectedButton, new BaseEventData(eventSystem));
    }

    public void MenuButton()
    {
        //TODO: TP2 - Fix - Hardcoded value/s
        SceneManager.LoadScene(buttonToMenu);
        Time.timeScale = 1f;
    }
}
