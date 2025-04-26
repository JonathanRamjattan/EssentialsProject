using UnityEngine;

public class Collectible : MonoBehaviour
{
    // This variable allows us to assign a particle effect in the Inspector
    public GameObject onCollectEffect;

    void Update()
    {
        // Rotate the collectible around the Y-axis
        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy the collectible
        Destroy(gameObject);

        // Instantiate the particle effect
        Instantiate(onCollectEffect, transform.position, transform.rotation);
    }
}
