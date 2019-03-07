using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerPhysics : MonoBehaviour
{
    public Rigidbody rb;
    public float ForceMovementForward;
    public float ForceMovementSideways;
   



    void FixedUpdate()
    {
        

        if(Input.GetKey("a"))
        {
            rb.AddForce(-ForceMovementSideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(ForceMovementSideways * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }
        if (Input.GetKey("s")) 
        {
            rb.AddForce(0,0, -ForceMovementForward * Time.deltaTime );
            
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0, ForceMovementForward * Time.deltaTime);
            
        }
       


        if (rb.position.y < - 2 )
        {

            FindObjectOfType<GameManager>().GameOver();

        }
        
        
    }
}
