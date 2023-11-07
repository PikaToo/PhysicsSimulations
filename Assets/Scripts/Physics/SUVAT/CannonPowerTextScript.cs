using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CannonPowerTextScript : MonoBehaviour
{    
    float cannonPower = 0.100f;
    Text boxText;
    // Start is called before the first frame update
    void Start()
    {
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        boxText.text = "Cannon Power: " + (cannonPower).ToString("F3");
    }
    public void SetCannonPower(System.Single val)
    {
        cannonPower = val;
    }
}
