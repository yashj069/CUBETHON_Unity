using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public player movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            
            FindObjectOfType<GameMananger>().EndGame();
            movement.enabled = false;
        }
    }
}
