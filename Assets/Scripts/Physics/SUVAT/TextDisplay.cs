using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    GameObject ball;
    Ball scriptComponent;
    GameObject self;
    GameObject rotationObject;
    float yVel;
    float xVel;
    Text boxText;
    bool goFire = false;

    // Rounds numbers bigger than 99 to 2 significant figures
    static float RoundTo2SF(float d) 
    {    
    int i = 0;

    while(d > 99) 
        {
            d /= 10;
            i++;
        }

    d = Mathf.Round(d);

    for(int j = 0; j < i; j++) 
        {
            d *= 10;
        }

    return d;
    }


    // Start is called before the first frame update
    void Start()
    {
        self = GameObject.Find("Information");
        boxText = self.GetComponent<Text>();      

        ball = GameObject.Find("Ball");
        scriptComponent = ball.GetComponent<Ball>();      // Getting script

    }

    // Update is called once per frame
    void Update()
    {
        
        if (!goFire) 
            {
                yVel = 0;
                xVel = 0;
            }

        if (goFire) 
            {
                yVel = Mathf.Sin(scriptComponent.rotationPoint) * scriptComponent.cannonPower * 10000;
                xVel = Mathf.Cos(scriptComponent.rotationPoint) * scriptComponent.cannonPower * 10000;
            }
        
        float travelTime = yVel/(scriptComponent.gravity*10000);
        
        rotationObject = GameObject.Find("Cannon Rotation Pivot");

        boxText.text = 

        "Initial x Velocity: " + xVel.ToString("F0") + "\r\n" +
        "Initial y Velocity: " + yVel.ToString("F0") + "\r\n" +
        "\r\n" +
        "Time to Travel: " + travelTime.ToString("F0") + "\r\n" +
        "Distance Travelled: " + (travelTime * xVel).ToString("F0") + "\r\n"
        ;
        

    }
    public void Fire()
    {
        if(goFire) { 
            goFire = false;
        } else {
            goFire = true;
        }
    }
}
