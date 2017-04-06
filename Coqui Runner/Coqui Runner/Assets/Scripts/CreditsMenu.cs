using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour {

    public GameObject mainMenu;

    public void BackToMain()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }


}
