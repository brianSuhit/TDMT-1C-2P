using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputLogic : MonoBehaviour
{
    [SerializeField] private GameObject creditsMenu;
    public void StartButton()
    {
        //TODO: TP2 - Fix - Hardcoded value/s
        SceneManager.LoadScene("TutorialLevel");
    }

    public void CreditsButton()
    {
        creditsMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        creditsMenu.SetActive(false);
    }
}
