using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static TextMeshProUGUI textPlayerScore;

    public static TextMeshProUGUI textAIScore;

    public static int playerScore;

    public static int AIScore;
    public GameObject ball;


    void Start()
    {
        GameObject objPlayerScore = GameObject.Find("Text_PlayerScore");
        textPlayerScore = objPlayerScore.GetComponent<TextMeshProUGUI>();
        GameObject objAIScore = GameObject.Find("Text_AIScore");
        textAIScore = objAIScore.GetComponent<TextMeshProUGUI>();
        Instantiate(ball);
    }

    public static void Score(string wallID)
    {
        if (wallID == "GO_LeftWall")
        {
            playerScore++;
            textPlayerScore.text = playerScore.ToString();
        }
        else
        {
            AIScore++;
            textAIScore.text = AIScore.ToString();
        }
    }
}
