using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassTextScript : MonoBehaviour
{    
    float mass = 1;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Mass: " + (mass).ToString("F2") + " kg";
    }
    public void SetMass(System.Single val)
    {
        mass = val;
    }
}
