using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddParticleScript : MonoBehaviour
{
    GameObject particle;
    float temperature = 273f;
    // Start is called before the first frame update
    void Start()
    {
        particle = GameObject.Find("Particle");
    }

    public void MakeParticle()
    {
        for(int i = -1; i < 2; i ++)
            {
            GameObject newParticle = GameObject.Instantiate(particle, new Vector3(i, 0, 0), Quaternion.identity, transform);
            newParticle.GetComponent<ParticleScript>().speed = temperature*2/273f;
            }
    }

    public void SetTemperature(System.Single val)
    {
        temperature = val;
    }

}
