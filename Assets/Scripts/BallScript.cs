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
            rb.AddForce(new Vector3(20, -15, 0));
        }
        else
        {
            rb.AddForce(new Vector3(-20, -15, 0));
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

    void OnCollisionEnter3D(Collision coll)
    {
        if (coll.collider.CompareTag("Paddle"))
        {
            Vector3 vel = rb.velocity;
            vel.x = rb.velocity.x;
            vel.y =
                (rb.velocity.y / 2) +
                (coll.collider.attachedRigidbody.velocity.y / 3);
            rb.velocity = vel;
        }
    }
}
