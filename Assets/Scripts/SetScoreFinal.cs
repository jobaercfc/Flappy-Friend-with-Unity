using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScoreFinal : MonoBehaviour {

    public Text scoreSet;

    void Start()
    {
        Debug.Log("jkk" + " " + GetScore.playerScore);
        scoreSet.text = "Your Score : " + GetScore.playerScore + "";
    }

   
}
