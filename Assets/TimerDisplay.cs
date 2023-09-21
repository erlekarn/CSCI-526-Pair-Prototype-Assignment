using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerDisplay : MonoBehaviour
{
    EllipticalMotion ellipticalMotion;
    private float timer = 0f;

    void Update()
    {
               
            // Update the timer
            timer += Time.deltaTime;
        
    }
    public void StartTimerDisplay()
    {
        timer = 0f; // Reset the timer.
        enabled = true; // Enable the TimerDisplay script.
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
