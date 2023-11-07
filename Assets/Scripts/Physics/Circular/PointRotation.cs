using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointRotation : MonoBehaviour
{
    float angularVelocity = 1;            // Value in radians.
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0f, 0f, angularVelocity*180f/3.14f/50f);
    }
    public void setAngularVelocity(System.Single val)
    {
        angularVelocity = val;
    }
}
