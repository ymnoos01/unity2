using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clipboard_selector : MonoBehaviour
{
    public TMP_Text winText;
    public Button restartButton;

    private static bool hasPlayerWon = false;
    private static int requiredClipboards = 1;
    private static int collectedClipboards = 0;

    // Reference to the character controller script that controls camera rotation
    //public CharacterControllerScript characterControllerScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ReactToPlayer();
        }
    }

    private void ReactToPlayer()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
            collectedClipboards++;

            if (collectedClipboards >= requiredClipboards && !hasPlayerWon)
            {
                WinGame();
            }
        }
    }

    private void WinGame()
    {
        hasPlayerWon = true;

        // Show the "You Win" text
        if (winText != null)
        {
            winText.text = "You Win!";
            winText.gameObject.SetActive(true);
        }

        // Show the Restart button
        if (restartButton != null)
        {
            restartButton.gameObject.SetActive(true);
            restartButton.onClick.AddListener(RestartGame); // Add listener for the button click
        }

        // // Disable mouse look in the character controller script
        // if (characterControllerScript != null)
        // {
        //     characterControllerScript.enabled = false;
        // }
    }

    // Method to be called when the button is clicked
    public void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
