using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI textPlayerScore;
    public TextMeshProUGUI textAIScore;

    public static int playerScore;
    public static int AIScore;

    GameObject ball;

    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }

    public static void Score (string wallID) {
    if (wallID == "GO_RightWall")
    {
        playerScore++;
    } else
    {
        AIScore++;
    }
}

}
