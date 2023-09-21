using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    private float timer = 0f;
    private bool timerStarted = false; // Track if the timer has started.
    private float scriptRuntimeDifference = 0f;
    void Update()
    {
        if (timerStarted)
        {
            // Check if the timer has exceeded scriptRuntimeDifference.
            if (timer > scriptRuntimeDifference)
            {
                Debug.Log("Game Over - Timer exceeded scriptRuntimeDifference");
                Time.timeScale = 0f; // Pause the game.
                timerStarted = false; // Stop the timer.
            }
            else
            {
                timer += Time.deltaTime;
            }
        }



    }
    public void StartTimerDisplay(float RuntimeDiff)
    {
        Debug.Log("In STartTimerDisplay");
        scriptRuntimeDifference = RuntimeDiff;
        timer = 0f; // Reset the timer.
        timerStarted = true; // Set to true to start the timer.
    }
    void OnGUI()
    {
        // Convert timer to minutes and seconds
        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        // Display the timer on the screen
        GUI.Label(new Rect(10, 10, 100, 20), string.Format("{0:00}:{1:00}", minutes, seconds));
    }

    // Rest of your code...
}
