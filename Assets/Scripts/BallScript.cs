using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private Rigidbody rb;

    private float speed = 10;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        StartCoroutine(StartGame());
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(2);
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            Vector3 dir = new Vector3(1, Random.Range(-7, 7), 0).normalized;
            rb.velocity = dir * speed;
        }
        else
        {
            Vector3 dir = new Vector3(-1, Random.Range(-7, 7), 0).normalized;
            rb.velocity = dir * speed;
        }
        yield return null;
    }

    void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }

    void RestartGame()
    {
        ResetBall();
        StartCoroutine(StartGame());
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
