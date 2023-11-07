using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AngVelTextScript : MonoBehaviour
{
    float angularVelocity = 1;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Angular Velocity: " + (angularVelocity).ToString("F2") + " rad/s";
    }
    public void SetAngularVelocity(System.Single val)
    {
        angularVelocity = val;
    }
}
