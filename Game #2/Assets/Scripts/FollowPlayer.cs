﻿using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    public float SmoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate () {

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);

    }

}
