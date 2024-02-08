using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReloader : MonoBehaviour
{
    public void ReloadSampleScene()
    {
        Debug.Log("Reload Sample Scene button clicked!");
        SceneManager.LoadScene("SampleScene");
    }
}