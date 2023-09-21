using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptRuntimeDifferenceDisplay : MonoBehaviour
{
    public EllipticalMotion ellipticalMotion; // Reference to the EllipticalMotion script.
    private Text uiText;

    private void Start()
    {
        // Attach the EllipticalMotion script through the Inspector.
        // Drag and drop the GameObject containing the EllipticalMotion script.
        uiText = GetComponent<Text>();
    }

    private void Update()
    {
        
        // Check if the EllipticalMotion script is disabled.
        if (!ellipticalMotion.isEnabled)
        {
            // Calculate the script runtime difference.
            float scriptRuntimeDifference = ellipticalMotion.scriptEndTime - ellipticalMotion.scriptStartTime;

            // Display the script runtime difference on the screen using the UI Text component.
            uiText.text = "Script Runtime Difference: " + scriptRuntimeDifference.ToString("F2") + " seconds";
        }
        else
        {
            // Clear the UI Text when the script is still running.
            uiText.text = "";
        }
    }
}
