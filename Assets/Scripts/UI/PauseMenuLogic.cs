using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuLogic : MonoBehaviour
{
    [SerializeField] private GameObject PauseMenu;

    public void PauseButton()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeButton()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
