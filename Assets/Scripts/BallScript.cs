using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Invoke("GoBall", 0);
    }

    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb.AddForce(new Vector3(30, Random.Range(-15, 15), 0));
        }
        else
        {
            rb.AddForce(new Vector3(-30, Random.Range(-15, 15), 0));
        }
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }

    void RestartGame()
    {
        ResetBall();
        Invoke("GoBall", 1);
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketHeight)
    {
     
        return (ballPos.y - racketPos.y) / racketHeight;
    }


}
