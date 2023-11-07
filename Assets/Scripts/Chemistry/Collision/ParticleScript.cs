using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    Renderer render;
    public float speed = 2.0f;
    float red = 0.0f;
    float blue = 1.0f;

    Rigidbody2D rb;
    Collider2D[] otherParticles;
    Vector2 vel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        render = GetComponent<Renderer>();
        rb.velocity = new Vector2(0.2f * speed, 0.8f * speed);
    }
    void Update() 
    {
        vel = rb.velocity;
        red = (Mathf.Abs(vel.x)+Mathf.Abs(vel.y))/5;
        blue = 1.0f - red;
        render.material.SetColor("_Color", new Color(red, 0, blue, 1));    
    }
}
