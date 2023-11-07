using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YArrow : MonoBehaviour
{
    GameObject box;
    GameObject self;
    Renderer ObjectRenderer;
    BoxScript scriptComponent;
    float angle = 0.0f;
    bool visible = true;
    Renderer[] RendererArray;
    // Start is called before the first frame update
    void Start()
    {
        box = GameObject.Find("Box");
        scriptComponent = box.GetComponent<BoxScript>();

        self = GameObject.Find("Y-Arrow");
        ObjectRenderer = GetComponent<Renderer>();

        RendererArray = GetComponentsInChildren<Renderer>();

        Debug.Log(Mathf.Cos(10));


    }

    // Update is called once per frame
    void Update()
    {
        angle = scriptComponent.z_rotation*3.141592f/180f;          // Getting angle and converting to rad.
        transform.localScale = new Vector3(0.4f, 4*Mathf.Cos(angle), 1f);   // Changing size based on angle.
        
        float yPos = -2f;
        yPos += (4-transform.localScale.y)/2;
        transform.localPosition = new Vector3(0f, yPos, -1f);

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
