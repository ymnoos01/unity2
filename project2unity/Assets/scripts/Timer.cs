using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float totalTime = 160f; // Total time in seconds (10 minutes)
    private float timeRemaining;

    public TextMeshProUGUI timerText;

    void Start()
    {
        timeRemaining = totalTime;
    }

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
             SceneManager.LoadScene("win_screen");
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes , seconds);
    }
}

// using UnityEngine;
// using TMPro;
// using UnityEngine.SceneManagement;

// public class Timer : MonoBehaviour
// {
//     public float totalTime = 60f; // Total time in seconds (1 minute)
//     private float timeRemaining;

//     public TextMeshProUGUI timerText;

//     void Start()
//     {
//         timeRemaining = totalTime;
//     }

//     void Update()
//     {
//         if (timeRemaining > 0)
//         {
//             timeRemaining -= Time.deltaTime;
//             UpdateTimerDisplay();
//         }
//         else
//         {
//              SceneManager.LoadScene("win_screen");
//         }
//     }

//     void UpdateTimerDisplay()
//     {
//         int seconds = Mathf.FloorToInt(timeRemaining % 60);
//         timerText.text = string.Format("{0:00}", seconds);
//     }
// }
