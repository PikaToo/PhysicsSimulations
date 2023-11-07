using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameObject point;
    GameObject self;
    bool fired = false;
    bool goFire = false;
    bool onGround = false;
    public float gravity = 0.000981f;
    public float cannonPower = 0.1f;
    public float rotationPoint;
    float yVel;
    float xVel;
    // Start is called before the first frame update
    void Start()
    {
        point = GameObject.Find("Cannon Rotation Pivot");
        self = GameObject.Find("Ball");
    }

    public void SetGravity(System.Single grav)
    {
        gravity = (grav/10000); 
    }

    public void SetCannonPower(System.Single power)
    {
        cannonPower = power;
    }

    // Update is called once per frame
    void Update()
    {
     if (!fired)
        {

            // Getting initial fire values
            rotationPoint = point.transform.eulerAngles.z;
            rotationPoint = rotationPoint * 0.01745329f;                // From degrees to radians.

            yVel = Mathf.Sin(rotationPoint) * cannonPower;
            xVel = Mathf.Cos(rotationPoint) * cannonPower;

            // Firing
            if (goFire)
                {
                self.transform.parent = null;
                fired = true;
                }

        }
    
     if (fired && !onGround) 
        {
         yVel -= gravity;
         self.transform.position += new Vector3(xVel, yVel, 0);
        }
    
    if (self.transform.position.y < -3.5) 
        {
            onGround = true;
        }
    
    if (!goFire) 
        {
            onGround = false;
            fired = false;
            self.transform.parent = point.transform;
            self.transform.localPosition = new Vector3(0f, 0f, -1f);
        }


    }
    public void Fire()
    {
        if(goFire) { 
            goFire = false;
        } else {
            goFire = true;
        }
    }

}
