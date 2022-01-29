using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainMenuManager : MonoBehaviour
{
    public GameObject mainMenu, credits;

    
    public void CreditsScreen()
    {
        mainMenu.SetActive(false);
        credits.SetActive(true);
    }

    public void MainMenuScreen()
    {
        credits.SetActive(false);
        mainMenu.SetActive(true);        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }
}
