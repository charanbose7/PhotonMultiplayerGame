using UnityEngine;
using Photon.Pun;

public class CapsuleController : MonoBehaviourPun
{
    public float speed = 5.0f;  // The speed of the capsule

    // Update is called once per frame
    void Update()
    {
        // Only move the capsule if it belongs to the local player
        if (photonView.IsMine)
        {
            // Get the horizontal and vertical axes of the keyboard input
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");

            // Calculate the new position of the capsule
            Vector3 newPos = transform.position + new Vector3(hAxis, 0, vAxis) * speed * Time.deltaTime;
            // Move the capsule to the new position
            transform.position = newPos;

            // Update the position of the capsule on the network
            photonView.RPC("UpdatePosition", RpcTarget.OthersBuffered, transform.position);
        }
    }

    // Update the position of the capsule for other players
    [PunRPC]
    void UpdatePosition(Vector3 newPos)
    {
        transform.position = newPos;
    }
}