using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public float moveSpeed = 2f;

    private Vector3 Vec;

    void Update()
    {
        transform.position =
            new Vector3(transform.position.x,
                transform.position.y +
                Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime,
                transform.position.z);
        if (transform.position.y < -2.3f)
            transform.position = new Vector3(5.85f, -2.3f, 0);
        else if (transform.position.y > 2.3f)
            transform.position = new Vector3(5.85f, 2.3f, 0);
    }
}
