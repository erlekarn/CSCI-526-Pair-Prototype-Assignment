using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float attractionForce = 100f;
    public float attractionRadius = 50f;


    private void FixedUpdate()
    {
        Collider2D[] attractableObjects = Physics2D.OverlapCircleAll(transform.position, attractionRadius);

        foreach (Collider2D obj in attractableObjects)
        {
            if (obj.CompareTag("Attractable"))
            {
                Rigidbody2D rb = obj.GetComponent<Rigidbody2D>();
                if (rb != null)
                {
                    Vector2 direction = transform.position - obj.transform.position;
                    rb.AddForce(direction.normalized * attractionForce);

                }
            }
        }
    }

    void OnDrawGizmos()
    {
        // Draw the gravity field radius in the Scene view
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attractionRadius);
    }
}