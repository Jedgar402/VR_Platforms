using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GazeInteractiveObject : MonoBehaviour
{
    public Text gazedText;

    public string gazedString;

    public Color highlightColor = Color.yellow;
    private Color originalColor;
    private Renderer objectRenderer;

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        // Store the original color
        originalColor = objectRenderer.material.color;
    }

    public void OnGazeEnter()
    {
        gazedText.text = gazedString;
        // Highlight the object when player's gaze enters
        objectRenderer.material.SetColor("_Color", highlightColor);
    }

    public void OnGazeExit()
    {
        gazedText.text = "";
        // Reset object colour when player's gaze exits
        objectRenderer.material.SetColor("_Color", originalColor);
    }
}
