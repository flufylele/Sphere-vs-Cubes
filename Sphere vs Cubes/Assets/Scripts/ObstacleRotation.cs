using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class ObstacleRotation : MonoBehaviour
{
    public Transform obstacol;
    public int speed;
  
    void Update()
    {
        obstacol.Rotate(0, speed, 0);

    }
}
