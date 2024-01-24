using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_game : MonoBehaviour
{
    public void RestartGame()
    {
        // Load the current scene (restart)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

