using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{

    public Transform player;
    public Text Score_text;


    void Update()
    {
        Score_text.text = player.position.z.ToString("0");
    }
}
