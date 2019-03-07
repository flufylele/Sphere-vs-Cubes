using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Level : MonoBehaviour
{
    

    public void Level_Change(string levelName)
    {
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }


    
}
