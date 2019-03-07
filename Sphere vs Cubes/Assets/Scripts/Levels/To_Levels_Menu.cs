using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Levels_Menu : MonoBehaviour
{
    public void Change()
    {
        SceneManager.LoadScene("Levels_1", LoadSceneMode.Single);
    }
}
