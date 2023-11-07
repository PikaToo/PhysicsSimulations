using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float z_rotation = 0.0f;
    void Start()
    {
        
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
