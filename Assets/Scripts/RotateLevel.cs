using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLevel : MonoBehaviour
{
    public float sensitivity = 0.8f;

    private Vector3 mouse_Reference;
    private Vector3 mouse_Offset;
    private Vector3 rotation;

    private bool isRotating;

    void Update()
    {
        if (isRotating)
        {
            mouse_Offset = Input.mousePosition - mouse_Reference;

            // Adjust rotation calculation based on mouse movement
            rotation.y = -(mouse_Offset.x) * sensitivity;

            // Apply rotation to the object
            transform.Rotate(rotation);

            // Update the mouse reference to the current position
            mouse_Reference = Input.mousePosition;
        }
    }

    void OnMouseDown()  
    {
        isRotating = true;

        // Set reference point for the mouse position
        mouse_Reference = Input.mousePosition;
    }

    void OnMouseUp()  
    {
        isRotating = false;
    }
}
