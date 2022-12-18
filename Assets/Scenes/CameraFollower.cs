using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform player; // the player object to follow
    public Vector3 offset; // the offset relative to the player's position

    void LateUpdate()
    {
        // Set the camera's position to the player's position plus the offset
        transform.position = player.position + offset;
    }
}
