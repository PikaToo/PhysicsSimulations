using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomScript : MonoBehaviour
{
    float radius = 100.0f;
    float electronegativity = 2.000f;
    float otherElectronegativity = 2.000f;
    float distance = 200.0f;
    float xSign = 1f; 
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
        if(transform.localPosition.x < 0)
        {
            xSign = -1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        distance = radius;
        if(electronegativity < otherElectronegativity)
            {
                distance -= 9f*(otherElectronegativity - electronegativity);
            }
        
        render.material.SetColor("_Color", new Color(electronegativity/4, (4-electronegativity)/4, 0, 1));
        transform.localScale = new Vector3(0.01f*radius, 0.01f*radius, 1f);
        transform.localPosition = new Vector3(xSign*distance*0.01f, 0f, -1f);

    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
    public void SetElectronegativity(System.Single val)
    {
        electronegativity = val;
    }
    public void SetOtherElectronegativity(System.Single val)
    {
        otherElectronegativity = val;
    }
}
