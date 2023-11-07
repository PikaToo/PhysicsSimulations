using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumScript : MonoBehaviour
{
    float l = 2f;
    float g = 9.81f;
    float angle = 30f;
    float angularVelocity = 0f;
    float angularAcceleration = 0f;
    bool moving = true;

    void Start()
    {

    }

    void FixedUpdate()
    {
        if(moving)
            {
            angle = transform.rotation.eulerAngles.z;
            angularAcceleration = -g * Mathf.Sin(ToRad(angle)) / l / 10;
                // angular acceleration = - g * sin(theta) / L
            angularVelocity += angularAcceleration;
            transform.Rotate(0f, 0f, ToDegree(angularVelocity)/50);
            }
            else 
            {
            transform.localRotation = Quaternion.Euler(0f, 0f, angle);
            angularVelocity = 0;
            angularAcceleration = 0;
            }
    }

    private float ToRad(float degree)
    {
        return degree * Mathf.PI / 180;
    }

    private float ToDegree(float rad)
    {
        return rad * 180 / Mathf.PI;
    }

    public void Setl(System.Single val)
    {
        l = val;
    }

    public void Setg(System.Single val)
    {
        g = val;
    }
    public void SetAngle(System.Single val)
    {
        angle = val;
    }
    public void SetMoving()
    {
        if(moving)
            {
                moving = false;
            } else {
                moving = true;
            }
    }

}
