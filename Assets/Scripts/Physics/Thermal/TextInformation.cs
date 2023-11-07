using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextInformation : MonoBehaviour
{
    float mass = 1.00f;
    float heatCapacity = 1.00f;
    float temperatureChange = 0.00f;
    float energyChange = 0.00f;
    GameObject box;
    Text boxText;

    void Start()
    {
        boxText = GetComponent<Text>();
        box = GameObject.Find("Object");
    }
   void FixedUpdate()
    {
        if(box.transform.position.x <= -11)
            {
                temperatureChange += 0.01f;
            } else { 
                if (box.transform.position.x >= 11) 
                {
                    temperatureChange -= 0.01f;
                }
            }
    }
    void Update()
    {
        energyChange = mass * heatCapacity * temperatureChange;

        boxText.text = 
        "Temperature Change: "      + (temperatureChange).ToString("F2")    + "K  ||  " +
        "Energy Change: "           + (energyChange).ToString("F2")         + "J"
        ;
    }

    public void setHeatCapacity(System.Single val) 
    {
        heatCapacity = val;
    }
    public void setMass(System.Single val) 
    {
        mass = val;
    }
}
