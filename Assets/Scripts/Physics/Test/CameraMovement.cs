using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform viewArea;
    
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void LateUpdate()
    {
        GameObject player = GameObject.Find ("Player");
        Transform playerTransform = player.transform;
        Vector3 playerPosition = playerTransform.position;
        transform.position = new Vector3(playerPosition.x, playerPosition.y, -10);
       
    }
}
