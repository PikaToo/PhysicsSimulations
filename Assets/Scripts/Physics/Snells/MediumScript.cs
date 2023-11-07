using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumScript : MonoBehaviour
{
    float n = 1;
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        render.material.SetColor("_Color", new Color(0, 0, 1, ((n-1)/2)));   
    }

    public void setN(System.Single val)
    {
        n = val;
    }
}
