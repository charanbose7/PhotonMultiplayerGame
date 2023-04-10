using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    public float speed = 5.0f;  // The speed of the capsule

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axes of the keyboard input
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        // Calculate the new position of the capsule
        Vector3 newPos = transform.position + new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;

        // Move the capsule to the new position
        transform.position = newPos;
    }
}
