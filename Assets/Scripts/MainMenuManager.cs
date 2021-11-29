using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionMenu;
    public GameObject creditsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Credits()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void Option()
    {
        mainMenu.SetActive(false);
        optionMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        optionMenu.SetActive(false);
        creditsMenu.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
