using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float totalTime = 600f; // Total time in seconds (10 minutes)
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
            // Time's up! Transition to another scene
            // For now, I'll just print a message
            //Debug.Log("Time's up!");
            // Replace the line above with the scene transition code
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
