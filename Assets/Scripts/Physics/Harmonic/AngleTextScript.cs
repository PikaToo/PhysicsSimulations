using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngleTextScript : MonoBehaviour
{
    float angle = 30.00f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Angle: " + (angle).ToString("F2") + " degrees";
    }
    public void SetAngle(System.Single val)
    {
        angle = val;
    }
}
