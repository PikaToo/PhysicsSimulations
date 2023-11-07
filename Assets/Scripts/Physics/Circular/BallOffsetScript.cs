using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallOffsetScript : MonoBehaviour
{
    float mass = 1f;
    float size = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        size = Mathf.Sqrt(mass);
        transform.localScale = new Vector3(1f/size, 1f/size, 1f);
    }
    public void SetMass(System.Single val)
    {
        mass = val;
    }
}
