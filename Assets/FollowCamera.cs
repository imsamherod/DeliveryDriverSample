using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    void LateUpdate()
    {
        // Vector is to add camera offset
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
