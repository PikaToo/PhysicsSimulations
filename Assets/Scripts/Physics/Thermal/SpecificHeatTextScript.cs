using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecificHeatTextScript : MonoBehaviour
{    
    float specificHeat = 1.00f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Specific Heat Capacity: " + (specificHeat).ToString("F2") + " J/K/kg";
    }
    public void SetSpecificHeat(System.Single val)
    {
        specificHeat = val;
    }
}
