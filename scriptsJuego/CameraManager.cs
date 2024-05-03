using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 0, -10);
    public float smoothTime = 0.25f;

    Vector3 currentVelocity;

    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(
            transform.position,
            target.position + offset,
            ref currentVelocity, smoothTime);
    }
}