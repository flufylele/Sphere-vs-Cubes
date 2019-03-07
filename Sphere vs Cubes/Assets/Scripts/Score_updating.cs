
using UnityEngine;



public class Score_updating : MonoBehaviour
{
    
    TextMesh text;
    public Transform player;
    public Vector3 offset;
    
    

    void Start()
    {

        text = gameObject.GetComponent("TextMesh") as TextMesh;
    }

    void Update()
    {
        transform.position = player.position + offset;
        text.text = "Score: " + ((int)Time.time).ToString();
        
    }
}
