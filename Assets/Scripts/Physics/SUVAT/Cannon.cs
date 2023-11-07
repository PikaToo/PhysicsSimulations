using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    GameObject self;
    float z_rotation = 45;
    // Start is called before the first frame update
    void Start()
    {
        self = GameObject.Find("Cannon Rotation Pivot");
    }

    // Update is called once per frame
    void Update()
    {
        transform.localRotation = Quaternion.Euler(0f, 0f, z_rotation);
    }
    
    public void SetAngle(System.Single val)
    {
        z_rotation = val;
    }
}
