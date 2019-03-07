
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Game_Manager;

    void OnTriggerEnter(Collider end)
    {
        Game_Manager.CompleteLevel();
    }

}
