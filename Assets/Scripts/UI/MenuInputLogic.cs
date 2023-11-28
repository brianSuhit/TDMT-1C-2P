using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuInputLogic : MonoBehaviour
{
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject MainMenu;
    [SerializeField] private string startButton = "add level name here";
    [SerializeField] private GameObject newFirstSelectedButton;
    [SerializeField] private GameObject newSecondSelectedButton;

    public void StartButton()
    {
        //TODO: TP2 - Fix - Hardcoded value/s
        SceneManager.LoadScene(startButton);
    }

    public void CreditsButton()
    {
        MainMenu.SetActive(false);
        creditsMenu.SetActive(true);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(newFirstSelectedButton, new BaseEventData(eventSystem));
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        MainMenu.SetActive(true);
        creditsMenu.SetActive(false);
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(newSecondSelectedButton, new BaseEventData(eventSystem));
    }
}
