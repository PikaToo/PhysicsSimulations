using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickScript : MonoBehaviour
{
    float radius = 1f;
    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(0.1f, radius, 1f);
        transform.localPosition = new Vector3(0f, -(radius/2), 0f);
    }
    public void SetRadius(System.Single val)
    {
        radius = val;
    }
}
