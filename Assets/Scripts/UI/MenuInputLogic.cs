using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuInputLogic : MonoBehaviour
{
    [SerializeField] private GameObject creditsMenu;
    [SerializeField] private GameObject MainMenu;
    //[SerializeField] private GameObject itemsButton;

    public void StartButton()
    {
        //TODO: TP2 - Fix - Hardcoded value/s
        SceneManager.LoadScene("TutorialLevel");
    }

    public void CreditsButton()
    {
        MainMenu.SetActive(false);
        creditsMenu.SetActive(true);
        //var eventSystem = EventSystem.current;
        //eventSystem.SetSelectedGameObject(itemsButton, new BaseEventData(eventSystem));
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        MainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }
}
