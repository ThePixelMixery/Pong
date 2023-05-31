using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
    
    public GameObject ball;
    public GameObject particles;
    

    void OnTriggerEnter (Collider hitInfo) {
        if (hitInfo.name == "Mesh_Ball(Clone)")
        {
            string wallName = transform.name;
            ScoreKeeper.Score(wallName);
            ballPos Vector3 = new Vector3(hitInfo.transform.pos);
            hitInfo.gameObject.SendMessage("KillBall", 0, SendMessageOptions.RequireReceiver);
            Instantiate(particles, (0,0,0), (0f,-90.0f,0f,1.0f));
            Instantiate(ball);
        }
    }
}