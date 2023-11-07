using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AverageTemperatureScript : MonoBehaviour
{
    Text boxText;
    Transform particleCollection; 
    float totalVelocity = 0.0f;
    int numberOfParticles = 0;
    float averageVelocity = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        particleCollection = GameObject.Find("Particle Source").GetComponent<Transform>();
        boxText = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        totalVelocity = 0.0f;
        numberOfParticles = 0;
        foreach (Transform child in particleCollection)
            {
                Vector2 vel = child.GetComponent<Rigidbody2D>().velocity;
                totalVelocity += Mathf.Sqrt(vel.x*vel.x + vel.y*vel.y);
                numberOfParticles += 1;
            }
        averageVelocity = totalVelocity/numberOfParticles;

        boxText.text = "Average Temperature: " + "\r\n" + 
                (averageVelocity*273/2).ToString("F2") + " K";
    }
}
