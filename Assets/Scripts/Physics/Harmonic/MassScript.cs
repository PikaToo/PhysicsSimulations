using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassScript : MonoBehaviour
{
    float l = 2f;
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
        transform.localScale = new Vector3(size/2, size/2, 1f);
        transform.localPosition = new Vector3(0f, -l, 0f);
    }
    public void Setl(System.Single val)
    {
        l = val;
    }
    public void SetMass(System.Single val)
    {
        mass = val;
    }
}
