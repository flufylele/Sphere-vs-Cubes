using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public PlayerPhysics script;
    public float restartDelay = 2f;
    public GameObject Complete_Level_UI;
    public GameObject Game_Over_UI;

    public void GameOver()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            script.enabled = false;
            Game_Over_UI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
        

        

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel ()
    {
        Complete_Level_UI.SetActive(true);
        Invoke("Restart", restartDelay);
    }


}
