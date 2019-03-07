using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostRamp : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;

    private Collision obstacol;
   

    public void OnCollisionEnter(Collision coliziune)
    {
        obstacol = coliziune;
    }


    void Update()
    {


        if (obstacol.collider.tag == "Boost_Ramp")
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
            
        }
    }
}
