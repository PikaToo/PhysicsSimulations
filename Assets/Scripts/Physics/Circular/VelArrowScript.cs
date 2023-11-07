using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelArrowScript : MonoBehaviour
{
    float radius = 1f;
    float angularVelocity = 1f;
    float mass = 1f;
    float size = 1f;

    void Update()
    {
        size = Mathf.Sqrt(mass);
        transform.localScale = new Vector3(0.4f, 0.5f*radius*angularVelocity, 1f);
        transform.localPosition = new Vector3((0.5f*radius*angularVelocity/2)+(size/2), 0f, 1f);
    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
    public void SetAngularVelocity(System.Single val)
    {
        angularVelocity = val;
    }
    public void SetMass(System.Single val)
    {
        mass = val;
    }
}
