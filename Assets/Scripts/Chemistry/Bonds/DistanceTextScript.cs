using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceTextScript : MonoBehaviour
{
    float radius = 100.0f;
    float otherRadius = 100.0f;
    float electronegativity = 2.000f;
    float otherElectronegativity = 2.000f;
    float distance = 200.0f;

    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        distance = radius + otherRadius - Mathf.Abs(9*(electronegativity-otherElectronegativity));
        if(electronegativity > otherElectronegativity) {
                boxText.text = 
                    "Approximate Bond Length: " + (distance).ToString("F1") + " pm" + "\r\n" + 
                    "Negative dipole: Left   ||  Positive dipole: Right";
            } else if (electronegativity < otherElectronegativity) {
                boxText.text = 
                    "Approximate Bond Length: " + (distance).ToString("F1") + " pm" + "\r\n" + 
                    "Negative dipole: Right   ||  Positive dipole: Left";
            } else {
                boxText.text =
                    "Approximate Bond Length: " + (distance).ToString("F1") + " pm" + "\r\n" + 
                    "Dipoles are equal."; 
            }

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
    public void SetOtherRadius(System.Single val)
    {
        otherRadius = val;
    }
}
