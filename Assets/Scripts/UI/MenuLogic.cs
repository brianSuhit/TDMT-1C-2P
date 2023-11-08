using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuInputReader : MonoBehaviour
{
    [SerializeField] GameObject creditsMenu;
    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditsScreen()
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