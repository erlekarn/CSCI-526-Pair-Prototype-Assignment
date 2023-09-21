using UnityEngine;

public class SpaceshipCollision: MonoBehaviour
{
    public Material greenMaterial; // Assign the green material in the Inspector.

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the trigger collider has collided with the planetary object.
        if (other.CompareTag("SpaceStation"))
        {
            // Change the material to green.
            Renderer planetRenderer = other.GetComponent<Renderer>();
            if (planetRenderer != null)
            {
                planetRenderer.material = greenMaterial;
            }
        }
    }
}
