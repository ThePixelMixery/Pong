using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {

    void OnTriggerEnter3D (Collider hitInfo) {
        if (hitInfo.name == "Ball")
        {
            string wallName = transform.name;
            GameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
        }
    }
}