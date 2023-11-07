using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonAngleScript : MonoBehaviour
{    
    float cannonAngle = 45.00f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Cannon Angle: " + (cannonAngle).ToString("F2") + "\u00B0";
    }
    public void SetCannonAngle(System.Single val)
    {
        cannonAngle = val;
    }
}
