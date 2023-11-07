using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RadiusTextScript : MonoBehaviour
{
    float radius = 1;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Radius: " + (radius).ToString("F2") + " m";
    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
}
