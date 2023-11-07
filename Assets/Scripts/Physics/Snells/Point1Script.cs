using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point1Script : MonoBehaviour
{
    float rotation = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0f, 0f, rotation);
    }

    public void SetRotation(System.Single val) 
    {
        rotation = -val;
    }
}
