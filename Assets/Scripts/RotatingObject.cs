using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RotatingObject : MonoBehaviour
{
    public XRController controller; // Reference to the XR controller
    public float rotationSpeed = 5f;

    private bool isGrabbed = false;
    private Vector3 lastControllerPosition;

    private void Update()
    {
        if (isGrabbed)
        {
            Vector3 currentControllerPosition = controller.transform.localPosition;
            float deltaPosition = currentControllerPosition.y - lastControllerPosition.y;

            // Rotate the sundial based on the controller's vertical movement
            transform.Rotate(Vector3.up, deltaPosition * rotationSpeed);

            lastControllerPosition = currentControllerPosition;
        }
    }

    private void OnDisable()
    {
        isGrabbed = false;
    }

    public void OnGrip(InputValue value)
    {
        isGrabbed = value.isPressed;
        lastControllerPosition = controller.transform.localPosition;
    }
}
