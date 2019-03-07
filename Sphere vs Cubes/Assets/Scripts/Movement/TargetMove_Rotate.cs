using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TargetMove_Rotate : MonoBehaviour
{
    public Transform[] target;
    public float speed_move;
    public Transform obstacol;
    public int speed_rotate;


    private int current;

    void Update()
    {
        if (transform.position != target[current].position)
        {
            obstacol.Rotate(0, speed_rotate, 0);
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed_move * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
            
        }
        else current = (current + 1) % target.Length;

    }

}