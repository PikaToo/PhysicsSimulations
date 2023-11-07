using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LengthTextScript : MonoBehaviour
{
    float length = 2.00f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Length: " + (length).ToString("F2") + " m";
    }
    public void SetLength(System.Single val)
    {
        length = val;
    }
}
