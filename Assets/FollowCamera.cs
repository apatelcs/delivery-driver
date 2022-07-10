using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject itemToFollow;
    // Update camera position to be the same as the car
    void LateUpdate()
    {
        transform.position = itemToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
