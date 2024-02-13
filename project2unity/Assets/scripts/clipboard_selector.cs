// using UnityEngine;
// using TMPro;
// using UnityEngine.SceneManagement;

// public class clipboard_selector : MonoBehaviour
// {
//     public string nextSceneName = "win_screen"; // Name of the scene to load after winning

//     private static bool hasPlayerWon = false;
//     private static int requiredClipboards = 1;
//     private static int collectedClipboards = 0;

//     private void OnTriggerEnter(Collider other)
//     {
//         if (other.CompareTag("Player"))
//         {
//             ReactToPlayer();
//         }
//     }

//     private void ReactToPlayer()
//     {
//         if (gameObject.activeSelf)
//         {
//             gameObject.SetActive(false);
//             collectedClipboards++;

//             if (collectedClipboards >= requiredClipboards && !hasPlayerWon)
//             {
//                 WinGame();
//             }
//         }
//     }

//     private void WinGame()
//     {
//         hasPlayerWon = true;
//         SceneManager.LoadScene(nextSceneName);
//     }
// }

using UnityEngine;
using UnityEngine.SceneManagement;

public class clipboard_selector : MonoBehaviour
{

    // Define variables for game state
    private static bool hasPlayerWon = false;
    private static int requiredClipboards = 3;
    private static int collectedClipboards = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ReactToPlayer();
        }
    }

    private void ReactToPlayer()
    {
        // Disable the clipboard object
        gameObject.SetActive(false);

        // Increment collected clipboards
        collectedClipboards++;

        // Check if all clipboards have been collected
        if (collectedClipboards >= requiredClipboards && !hasPlayerWon)
        {
            WinGame();
        }
    }

    private void WinGame()
    {
        // Set player win flag
        hasPlayerWon = true;

        // Load the win_screen scene
        SceneManager.LoadScene("win_screen");

        // Disable character controller and enable mouse cursor
        // if (characterControllerManager != null)
        // {
        //     characterControllerManager.DisableCharacterController();
        //     characterControllerManager.EnableMouseCursor();
        // }
    }
}
