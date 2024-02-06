using UnityEngine;
using UnityEngine.SceneManagement;

public class restart_game : MonoBehaviour
{
    public void ReloadSampleScene()
    {
        Debug.Log("Reload Sample Scene button clicked!");
        SceneManager.LoadScene("SampleScene");
    }
}
