using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectScript : MonoBehaviour
{
    Renderer render;
    float temperatureChange = 0.00f;
    float red = 0.5f;
    float blue = 0.5f;

    void Start()
    {
        render = GetComponent<Renderer>();
    }
    void FixedUpdate()
    {
        if(transform.position.x <= -11)
            {
                temperatureChange += 0.05f;
            } else { 
                if (transform.position.x >= 11) 
                {
                    temperatureChange -= 0.05f;
                }
            }
    }
    void Update()
    {
        red = 0.5f + (temperatureChange/10);
        blue = 0.5f - (temperatureChange/10);
        render.material.SetColor("_Color", new Color(red, 0, blue, 1));
    }

    public void SetX(System.Single pos)
    {
        transform.position = new Vector3(pos, transform.position.y, transform.position.z);
    }
    public void SetMass(System.Single mass)
    {
        float size = Mathf.Sqrt(mass);
        transform.localScale = new Vector3(size, size, 1f);
    }
}
