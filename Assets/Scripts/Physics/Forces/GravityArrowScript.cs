using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityArrowScript : MonoBehaviour
{
    GameObject self;
    Renderer ObjectRenderer;
    bool visible = true;
    Renderer[] RendererArray;
    // Start is called before the first frame update
    void Start()
    {
        self = GameObject.Find("Gravity Arrow");
        ObjectRenderer = GetComponent<Renderer>();

        RendererArray = GetComponentsInChildren<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Toggle()
    {
        if(visible)
            {
                visible = false;
                ObjectRenderer.enabled = false;
                foreach (Renderer rend in RendererArray)
                    {
                        rend.enabled = false;
                    }
            } 
            else 
                {
                    visible = true;
                    ObjectRenderer.enabled = true;
                    foreach (Renderer rend in RendererArray)
                    {
                        rend.enabled = true;
                    }
                }

    }

}
