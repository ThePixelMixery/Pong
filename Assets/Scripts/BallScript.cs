using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    
    private Rigidbody rb;

    private float speed = 10;

    public GameObject particles;

    void Start()
    {
        GameObject opponent = GameObject.Find("Mesh_LeftPaddle");
        opponent.GetComponent<OpponentAI>().ball=gameObject;
        rb = GetComponent<Rigidbody>();
        Invoke ("StartGame", 2.0f);
    }

    void StartGame()
    {
        Vector3 dir;

        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            dir = new Vector3(1, Random.Range(-7, 7), 0).normalized;
        }
        else
        {
            dir = new Vector3(-1, Random.Range(-7, 7), 0).normalized;
        }
        rb.velocity = dir * speed;
    }

    void KillBall()
    {
        Destroy(gameObject);
    }

    float hitFactor(Vector3 ballPos, Vector3 racketPos, float racketHeight)
    {
        return (ballPos.y - racketPos.y) / racketHeight;
    }

    //fix me
    void OnCollisionEnter(Collision coll)
    {

        if (coll.gameObject.name == "Mesh_LeftPaddle")
        {
            float y =
                hitFactor(transform.position,
                coll.transform.position,
                coll.collider.bounds.size.y);

            Vector3 dir = new Vector3(1, y, 0).normalized;

            rb.velocity = dir * speed;
        }

        // Hit the right Racket?
        if (coll.gameObject.name == "Mesh_RightPaddle")
        {
            float y =
                hitFactor(transform.position,
                coll.transform.position,
                coll.collider.bounds.size.y);

            Vector3 dir = new Vector3(-1, y, 0).normalized;

            rb.velocity = dir * speed;
        }
    }
}
