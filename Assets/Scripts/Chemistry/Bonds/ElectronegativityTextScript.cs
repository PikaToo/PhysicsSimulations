using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElectronegativityTextScript : MonoBehaviour
{
    float electronegativity = 2.000f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Electronegativity: " + (electronegativity).ToString("F3");
    }
    public void SetElectronegativity(System.Single val)
    {
        electronegativity = val;
    }
}
