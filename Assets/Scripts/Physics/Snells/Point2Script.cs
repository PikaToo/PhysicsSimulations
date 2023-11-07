using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point2Script : MonoBehaviour
{
    float n1 = 1;
    float n2 = 1;
    float angle1 = 0;
    float angle2 = 0;
    GameObject light2;
    Renderer render;
    float toBeAsin = 0;
    void Start()
    {
        light2 = GameObject.Find("Light 2");
        render = light2.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

        // Getting angle and seeing if should exist.
        toBeAsin = n1*Mathf.Sin(angle1*3.14f/180f)/n2;
        if(Mathf.Abs(toBeAsin) <= 1 && angle1 != 90)
            {
                angle2 = Mathf.Asin(toBeAsin)*180f/3.14f;    // Snell's law.
                transform.rotation = Quaternion.Euler(0f, 0f, angle2);
                render.enabled = true;
            } else {
                render.enabled = false;
            }
        
        // If no reflection, opaque. Else, translucent.
        if (n1 == n2) 
        {
            render.material.SetColor("_Color", new Color(1, 1, 1, 1));
        } else {
            render.material.SetColor("_Color", new Color(1, 1, 1, 0.6f));
        }
    }
    public void SetAngle1(System.Single val) 
    {
        angle1 = -val;
    }
    public void SetN1(System.Single val) 
    {
        n1 = val;
    }
    public void SetN2(System.Single val) 
    {
        n2 = val;
    }
}
