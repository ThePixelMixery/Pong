using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 0.0000001f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 position = transform.position;
        float translation = Input.GetAxis("Vertical") * moveSpeed;
        if (transform.position.y + translation < -2.3f)
            position.y = -2.3f;
        else if (transform.position.y + translation > 2.3f)
            position.y = 2.3f;
        else
            position.y += translation;
        transform.position = position;
    }
}
