using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource levelMusic;
    [SerializeField] private string buttonToMenu = "add level name here";


    public void PauseButton()
    {
        pauseMenu.SetActive(true);
        levelMusic.Pause();
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        pauseMenu.SetActive(false);
        levelMusic.Play();
        Time.timeScale = 1f;
    }

    public void MenuButton()
    {
        //TODO: TP2 - Fix - Hardcoded value/s
        SceneManager.LoadScene(buttonToMenu);
        Time.timeScale = 1f;
    }
}
