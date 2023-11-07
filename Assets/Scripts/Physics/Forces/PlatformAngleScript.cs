using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformAngleScript : MonoBehaviour
{    
    float platformAngle = 0.00f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Platform Angle: " + (platformAngle).ToString("F2") + "\u00B0";
    }
    public void SetPlatformAngle(System.Single val)
    {
        platformAngle = val;
    }
}
