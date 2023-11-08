using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInputLogic : MonoBehaviour
{
    [SerializeField] private GameObject creditsMenu;
    public void StartButton()
    {
        SceneManager.LoadScene("TutorialLevel");
    }

    public void CreditsButton()
    {
        creditsMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Me cierro");
    }

    public void MenuButton()
    {
        creditsMenu.SetActive(false);
    }
}
