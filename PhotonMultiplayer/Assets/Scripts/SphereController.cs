using UnityEngine;

public class SphereController : MonoBehaviour
{
    public Material material;  // The material to use for the sphere's color

    // Detect collisions with the capsule
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Triggered");
            // Change the color of the sphere's material
            GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
        }
    }
}
