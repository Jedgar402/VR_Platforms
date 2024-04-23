using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractionControl : MonoBehaviour
{
    public float maxGazeDistance = 10f;
    private RaycastHit hit;    
    // Track the last object gazed upon
    private GazeInteractiveObject lastGazeObject; 

    // Update is called once per frame
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
                // Exit Update() to prevent OnGazeExit being called
                return; 
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

