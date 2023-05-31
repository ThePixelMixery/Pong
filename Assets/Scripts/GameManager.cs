using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball;

    void Start()
    {
        Instantiate(ball);
    }
}
