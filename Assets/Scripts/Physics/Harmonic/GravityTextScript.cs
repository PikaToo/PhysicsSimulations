using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GravityTextScript : MonoBehaviour
{
    float gravity = 9.81f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Gravity: " + (gravity).ToString("F2") + " m/s/s";
    }
    public void SetGravity(System.Single val)
    {
        gravity = val;
    }
}
