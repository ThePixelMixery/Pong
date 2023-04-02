using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseGame : MonoBehaviour
{
    public Image playerPaddle;
    public Image LeftPaddle;

    public float maxHori= 170;
    public float minHori = -170;
    public Vector3 playerLoc = new Vector3();
    public float LeftPaddleLoc;

    public string score;

    void Start(){
    playerLoc.x = 370;
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow) && playerLoc.y >= minHori){
            Debug.Log("Down arrow was pressed");
            Debug.Log(playerLoc.y);
            playerLoc.y -= playerLoc.y*0.0001f;
            playerPaddle.transform.position= playerLoc;
        }
    }
}
