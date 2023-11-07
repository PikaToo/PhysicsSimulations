using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeScript : MonoBehaviour
{
    float l = 2.00f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(0.1f, l, 1f);
        transform.localPosition = new Vector3(0f, -l/2, 0f);
    }
    public void Setl(System.Single val)
    {
        l = val;
    }
}
