using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScore : MonoBehaviour {

    public Text Scorer;
   
    public static string playerScore;

    void Update()
    {
        GetPlayerName();
    }

    public void GetPlayerName()
    {
        playerScore = Scorer.text;
    }
}
