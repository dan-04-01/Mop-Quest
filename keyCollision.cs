using UnityEngine;

public class keyCollision : MonoBehaviour
{
    // This function is called when another collider enters the trigger collider attached to this GameObject.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the colliding object has a tag "Mysterio".
        if (collision.gameObject.CompareTag("m"))
        {
            // Destroy the key1 GameObject when colliding with Mysterio.
            Destroy(gameObject);

            // Find the barrier1 GameObject and destroy it.
            GameObject barrier1 = GameObject.Find("barrier1");
            if (barrier1 != null)
            {
                Destroy(barrier1);
            }
            else
            {
                Debug.LogWarning("Barrier1 not found!");
            }
            GameObject barrier2 = GameObject.Find("barrier2");
            if (barrier2 != null)
            {
                Destroy(barrier2);
            }
            else
            {
                Debug.LogWarning("Barrier2 not found!");
            }
            
        }
    }
}

