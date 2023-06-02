using UnityEngine;
using System.Collections;

public class SideWalls : MonoBehaviour {
    
    public GameObject ball;
    public GameObject particles;
    
    void OnTriggerEnter (Collider hitInfo) {
        if (hitInfo.name == "Mesh_Ball(Clone)")
        {
            GetComponent<AudioSource>().Play();
            string wallName = transform.name;
            ScoreKeeper.Score(wallName);
            Vector3 ballPos= new Vector3();
            ballPos = hitInfo.transform.position;
            hitInfo.gameObject.SendMessage("KillBall", 0, SendMessageOptions.RequireReceiver);
            if (wallName == "GO_RightWall"){
                Instantiate(particles, ballPos, Quaternion.Euler(0,-90,0));
            }            
            else
            {
                Instantiate(particles, ballPos, Quaternion.Euler(-180,-90,0));
            }
            Instantiate(ball);
        }
    }
}