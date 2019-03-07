using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player_Collision : MonoBehaviour
{
    public Rigidbody rb;
   





    void OnCollisionEnter(Collision coliziune)
    {
        if(coliziune.collider.tag== "Obstacle_hit")
        {
           
            FindObjectOfType<GameManager>().GameOver();
            

        }

    }

    
}
