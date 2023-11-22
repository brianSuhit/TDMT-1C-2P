using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private AudioSource levelMusic;
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
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
