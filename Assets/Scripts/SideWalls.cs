using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

    public GameObject ball;

    void OnTriggerEnter (Collider hitInfo) {
        if (hitInfo.name == "Mesh_Ball(Clone)")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("KillBall", 0, SendMessageOptions.RequireReceiver);
            Instantiate(ball);
        }
    }
}