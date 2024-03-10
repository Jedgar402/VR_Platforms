using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInteractiveObject : MonoBehaviour
{
    public Color highlightColor = Color.yellow;
    private Color originalColor;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        originalColor = objectRenderer.material.color;
    }

    public void OnGazeEnter()
    {
        // Highlight the object when player's gaze enters
        objectRenderer.material.color = highlightColor;
    }

    public void OnGazeExit()
    {
        // Reset object colour when player's gaze exits
        objectRenderer.material.color = originalColor;
    }
}
