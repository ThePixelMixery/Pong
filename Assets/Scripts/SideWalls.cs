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
            Vector3 ballPos= new Vector3();
            ballPos = hitInfo.transform.position;
            hitInfo.gameObject.SendMessage("KillBall", 0, SendMessageOptions.RequireReceiver);
            if (wallName == "GO_RightWall"){
                Instantiate(particles, ballPos, Quaternion.Euler(0,0,0));
            }            
            else
            {
                Instantiate(particles, ballPos, Quaternion.Euler(0,0,0));
                
            }
            Instantiate(ball);
        }
    }
}