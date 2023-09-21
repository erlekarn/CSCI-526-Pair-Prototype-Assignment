using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    private float timer = 0f;
    private bool timerStarted = false; // Track if the timer has started.

    void Update()
    {
        if (timerStarted)
        {
            Debug.Log("In update");

            timer += Time.deltaTime;
        }
    }
    public void StartTimerDisplay()
    {
        Debug.Log("In STartTimerDisplay");

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
