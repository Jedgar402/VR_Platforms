using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractionControl : MonoBehaviour
{
    public float maxGazeDistance = 10f;
    private RaycastHit hit;

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
                gazeObject.OnGazeEnter();
            }
        }
    }
}

