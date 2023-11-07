using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccArrowScript : MonoBehaviour
{
    float angularVelocity = 1f;
    void Update()
    {
        transform.localScale = new Vector3(1.5f*angularVelocity, -0.7f, 1f);   
        transform.localPosition = new Vector3(-1.5f*angularVelocity/2-1.25f, 0f, 1f);
    }
    public void SetAngularVelocity(System.Single val)
    {
        angularVelocity = val;
    }
}
