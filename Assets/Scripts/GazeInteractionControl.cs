using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractionControl : MonoBehaviour
{
    public float maxGazeDistance = 10f;
    private RaycastHit hit;
    private GazeInteractiveObject lastGazeObject; // Track the last object gazed upon

    void Update()
    {
        // Cast a ray from the center of the camera's view
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxGazeDistance))
        {
            // Check if the hit object has an interaction script attached
            GazeInteractiveObject gazeObject = hit.collider.GetComponent<GazeInteractiveObject>();
            if (gazeObject != null)
            {
                // Trigger interaction
                if (gazeObject != lastGazeObject)
                {
                    // If it's a new object, exit the previous one and enter the new one
                    if (lastGazeObject != null)
                    {
                        lastGazeObject.OnGazeExit();
                    }
                    gazeObject.OnGazeEnter();
                    lastGazeObject = gazeObject;
                }
                return; // Exit Update() to prevent OnGazeExit from being called
            }
        }

        // If no object is being gazed upon, exit the last one if exists
        if (lastGazeObject != null)
        {
            lastGazeObject.OnGazeExit();
            lastGazeObject = null;
        }
    }
}

