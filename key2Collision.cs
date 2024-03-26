using UnityEngine;

public class key2Collision : MonoBehaviour
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
            GameObject barrier = GameObject.Find("barrier3");
            if (barrier != null)
            {
                Destroy(barrier);
            }
            else
            {
                Debug.LogWarning("Barrier3 not found!");
            }
        }
    }
}
