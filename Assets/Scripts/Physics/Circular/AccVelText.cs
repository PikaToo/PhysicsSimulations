using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccVelText : MonoBehaviour
{    
    float radius = 1f;
    float angularVelocity = 1f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = 
        "Velocity: " + (radius*angularVelocity).ToString("F2") + " m/s" + "\r\n" + 
        "Centripetal Acceleration: " + (angularVelocity*angularVelocity*radius).ToString("F2") + " m/s/s"
        ;
    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
        public void SetAngularVelocity(System.Single val)
    {
        angularVelocity = val;
    }
}
