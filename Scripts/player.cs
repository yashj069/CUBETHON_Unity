using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody play;
    public float ForwardForce = 2000f;
    public GameObject Ground3;
    void FixedUpdate()
    {
        play.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            play.AddForce(900 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            play.AddForce(-900 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            play.AddForce(0, 0, 500 * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            play.AddForce(0, 0, -500 * Time.deltaTime);
        }
        if (play.position.y < -2f)
        {
            FindObjectOfType<GameMananger>().EndGame();
        }

    }
}
