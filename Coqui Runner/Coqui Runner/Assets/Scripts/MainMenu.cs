using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string playGameLevel;

    public GameObject creditsMenu;

    public void PlayGame()
    {
        SceneManager.LoadScene(playGameLevel);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShopMenu()
    {

    }

    public void CreditsMenu()
    {
        gameObject.SetActive(false);
        creditsMenu.SetActive(true);
    }

}
