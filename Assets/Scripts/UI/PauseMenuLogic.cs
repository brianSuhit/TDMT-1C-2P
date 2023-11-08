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
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(0);
    }
}
