using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //These variables are used for the SmoothDamp Function

    private Vector3 offset = new Vector3(0f, 0f, -10f);
    //this changes the amount of lag behind the camera, the larger the more lag
    private float smoothTime = 0.1f;
    //I assume this is the velocity of the camera following the target
    private Vector3 velocity = Vector3.zero;

    //this is to pick the camera target
    [SerializeField] private Transform target;

    private void Update()
    {
        
        Vector3 targetPosition = target.position + offset;
        //smoothdamp function helps smooth the camera
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}

