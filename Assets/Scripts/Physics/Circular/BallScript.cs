using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    float mass = 1f;
    float size = 1f;
    float radius = 1f;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        size = Mathf.Sqrt(mass);
        transform.localScale = new Vector3(0.5f*size, 0.5f*size, 1f);
        transform.localPosition = new Vector3(0f, -radius, -1f);
    }
    public void SetMass(System.Single val)
    {
        mass = val;
    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
}
