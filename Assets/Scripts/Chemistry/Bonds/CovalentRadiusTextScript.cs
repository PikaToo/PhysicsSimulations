using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CovalentRadiusTextScript : MonoBehaviour
{
    float radius = 100.0f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Covalent Radius: " + (radius).ToString("F1") + " pm";
    }
    public void SetCovalentRadius(System.Single val)
    {
        radius = val;
    }
}