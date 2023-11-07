using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point3Script : MonoBehaviour
{
    float rotation = 0f;
    float n1 = 1;
    float n2 = 1;
    GameObject light3;
    Renderer render;
    float toBeAsin = 0;
    void Start()
    {
        light3 = GameObject.Find("Light 3");
        render = light3.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetColor("_Color", new Color(1, 1, 1, 0.6f));
        transform.rotation = Quaternion.Euler(0f, 0f, rotation);

        // Getting refraction angle. If no refraction present, makes reflection light opaque.
        toBeAsin = n1*Mathf.Sin(rotation*3.14f/180f)/n2;
        if(Mathf.Abs(toBeAsin) <= 1 && rotation != -90)
            {
                render.material.SetColor("_Color", new Color(1, 1, 1, 0.6f));
            } else {
                render.material.SetColor("_Color", new Color(1, 1, 1, 1));
            }
        
        // If no reflection, hides self.
        if (n1 == n2 && rotation != -90) 
        {
            render.enabled = false;
        } else {
            render.enabled = true;
        }
    }

    public void SetRotation(System.Single val) 
    {
        rotation = val;
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
