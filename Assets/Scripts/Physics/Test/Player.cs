using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private float downwardMovement;
    private int jumpsAvailable;
    private Rigidbody2D rigidbodyComponent;
    private bool floating;
    [SerializeField] private Transform groundCheckTransform = null;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

          if ((Input.GetKeyDown(KeyCode.Space) | Input.GetKeyDown(KeyCode.W)) && jumpsAvailable > 0) {
               jumpKeyWasPressed = true;
               }
          
          if (Input.GetKey(KeyCode.S)) {
               downwardMovement = -1;
               } else {
                    downwardMovement = 0;
               }

          horizontalInput = 5 * Input.GetAxis("Horizontal");

    }

     // FixedUpdate is called once every physics update
     void FixedUpdate() 
     {
          rigidbodyComponent.velocity = new Vector2(horizontalInput, rigidbodyComponent.velocity.y + downwardMovement);

          if (Physics2D.OverlapCircleAll(groundCheckTransform.position, 0.1f).Length > 1) {
                    jumpsAvailable = 2;
               }

          if (jumpsAvailable == 0) {
                    return;
               }

          if (jumpKeyWasPressed) {    
               rigidbodyComponent.velocity = new Vector2(0, 0);
               rigidbodyComponent.AddForce(Vector2.up*8, ForceMode2D.Impulse);
               jumpsAvailable--;
               jumpKeyWasPressed = false;
               }
          
          if (floating) {

               if (rigidbodyComponent.velocity.y + 1 < 12) { 
                    rigidbodyComponent.velocity = new Vector2(rigidbodyComponent.velocity.x, rigidbodyComponent.velocity.y + 1);
               } else { 
                    rigidbodyComponent.velocity = new Vector2(rigidbodyComponent.velocity.x, 12);
               }

          }


     }

     void OnTriggerEnter2D(Collider2D Obj)
     {
          if(Obj.gameObject.tag == "Float")
          {
               floating = true;
          }

     }
     void OnTriggerExit2D(Collider2D Obj)
     {
          if(Obj.gameObject.tag == "Float")
          {
               floating = false;
               }

     }


}
