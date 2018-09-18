using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

    public void ExitGame()
    {
        Debug.Log("Exiting");
        Application.Quit();
    }


    public void StartGame(string name)
    {
        Application.LoadLevel(name);

    }
}
