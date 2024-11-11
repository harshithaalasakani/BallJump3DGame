using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Transform target;

    public float distance = 7.6f;
    public float height = 2.5f;
    public float damping = 1.1f;
    public float rotationDamping = 0f;

    public bool smoothRotation = true;
    public bool followBehind = true;

    void Awake()
    {
        target = GameObject.FindWithTag("Player").transform;

    }

    void Update()
    {
        Vector3 wantedPosition;

        if (followBehind)
        {
            wantedPosition = target.TransformPoint(0f,height,-distance);
        }
        else
        {
            wantedPosition = target.TransformPoint(0f, height, distance);

        }
        transform.position = Vector3.Lerp(transform.position, wantedPosition, Time.deltaTime * damping);
        if(smoothRotation)
        {
            Quaternion wantedRotation = Quaternion.LookRotation(target.position - transform.position, target.up);
            transform.rotation = Quaternion.Slerp(transform.rotation,wantedRotation,Time.deltaTime * rotationDamping);
        }
        else
        {
            transform.LookAt(target, target.up);
        }
    }
}
