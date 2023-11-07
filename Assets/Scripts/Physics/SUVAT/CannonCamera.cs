using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonCamera : MonoBehaviour
{
    int distanceFromCenter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Camera movement

        GameObject ball = GameObject.Find("Ball");
        float ballx = ball.transform.position.x;    // Camera follows ball.
        if (ballx < 0) {                            // Stopping camera from going off-screen.
            ballx = 0;
        }
        transform.position = new Vector3(ballx, 0, -10);

        // Making ground
        if (distanceFromCenter < ballx)
        {
            GameObject ground = GameObject.Find("FloorTile");
            Instantiate(ground, new Vector3(distanceFromCenter+20, -4.5f, 0), new Quaternion(0f, 0f, 0f, 0f));
            distanceFromCenter += 20;

        }




    }
}
