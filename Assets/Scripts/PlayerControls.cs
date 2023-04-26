using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public KeyCode moveUp = KeyCode.UpArrow;

    public KeyCode moveDown = KeyCode.DownArrow;

    public KeyCode moveLeft = KeyCode.LeftArrow;

    public KeyCode moveRight = KeyCode.RightArrow;

    public float speed = 10.0f;

    public float boundY = 2.25f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var vel = rb.velocity;
        if (Input.GetKey(moveUp))
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))
        {
            vel.y = -speed;
        }
        else
        {
            vel.y = 0;
        }
        rb.velocity = vel;

        var pos = transform.position;
        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }
}
