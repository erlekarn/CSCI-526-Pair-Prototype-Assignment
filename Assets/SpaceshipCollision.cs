using UnityEngine;

public class SpaceshipCollision: MonoBehaviour
{
    public Material greenMaterial; // Assign the green material in the Inspector.
    public int numberOfSpaceStationsCollided = 0;
    private bool gameEnd = false; // Track if the timer has started.

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger collider has collided with the planetary object.
        if (other.CompareTag("SpaceStation"))
        {
            // Change the material to green.
            Renderer planetRenderer = other.GetComponent<Renderer>();
            if (planetRenderer != null)
            {
                numberOfSpaceStationsCollided += 1;
                planetRenderer.material = greenMaterial;

                if(numberOfSpaceStationsCollided == 6)
                {
                    gameEnd = true;

                }
            }
        }
    }
    void OnGUI()
    {
        
        if (gameEnd)
        {
            GUIStyle gameOverStyle = new GUIStyle();
            gameOverStyle.normal.textColor = Color.green;
            gameOverStyle.fontSize = 24; // Set the font size.
            gameOverStyle.fontStyle = FontStyle.Bold; // Make the text bold.

            GUI.Label(new Rect(150, 105, 1000, 200), "YOU CURED ALL THE SPACE STATIONS. YOU WIN. GAME OVER", gameOverStyle);
            Time.timeScale = 0f; // Pause the game.
        }
    }
}
