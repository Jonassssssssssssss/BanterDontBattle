using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player; // Assign your player object in the Inspector

        void LateUpdate()
        {
            if (player != null)
            {
                Vector3 newPosition = transform.position;
                newPosition.x = player.position.x;
                newPosition.y = player.position.y;
                transform.position = newPosition;
            }
        }
}
