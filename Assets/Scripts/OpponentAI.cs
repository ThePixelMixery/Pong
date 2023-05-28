using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentAI : MonoBehaviour
{
    public GameObject ball;

    private float ballY;

    private float currentY;

    private Rigidbody rb;

    private float speed = 2f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ballY = Mathf.Clamp(ball.transform.position.y,-2.3f,2.3f);
        currentY = transform.position.y;
        Vector3 targetPosition = new Vector3(transform.position.x, ballY,transform.position.z);
        if (ballY != currentY)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}
