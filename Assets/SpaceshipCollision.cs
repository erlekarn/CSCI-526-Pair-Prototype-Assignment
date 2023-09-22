using UnityEngine;

public class SpaceshipCollision: MonoBehaviour
{
    public Material greenMaterial; // Assign the green material in the Inspector.
    public int numberOfSpaceStationsCollided = 0;
    private bool gameEnd = false; // Track if the timer has started.
    public Color whiteColor = Color.white; // Color for space stations after collision.

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger collider has collided with the planetary object.
        if (other.CompareTag("SpaceStation"))
        {
            // Change the material to green.
            SpriteRenderer spaceStationRenderer = other.GetComponent<SpriteRenderer>();
            if (spaceStationRenderer != null)
            {
                numberOfSpaceStationsCollided += 1;
                spaceStationRenderer.color = Color.white;

                if (numberOfSpaceStationsCollided == 6)
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

            GUI.Label(new Rect(80, 105, 1000, 200), "YOU CURED ALL THE SPACE STATIONS. YOU WIN. GAME OVER", gameOverStyle);
            Time.timeScale = 0f; // Pause the game.
        }
    }
}
