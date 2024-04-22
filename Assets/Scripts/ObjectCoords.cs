using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ObjectCoords : MonoBehaviour
{
    //Layer mask to filter the objects to detect
    public LayerMask objectLayer; 
    //Maximum distance for the raycast
    public float maxDistance = 10f; 
    //Reference to the TextMeshPro component
    public TextMeshPro displayText; 
    //Reference to the player's camera
    private Camera playerCamera;

    void Start()
    {
        //Get reference camera
        playerCamera = Camera.main;

        //Ensure the text is not visible at the start
        displayText.enabled = false;
    }

    void Update()
    {
        //Cast from player's camera
        Ray ray = playerCamera.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxDistance, objectLayer))
        {
            //Check if the object hit by the raycast is within specified layer
            GameObject hitObject = hit.collider.gameObject;

            //Get the X and Z coordinates of the hit
            float xCoord = hitObject.transform.position.x;
            float zCoord = hitObject.transform.position.z;

            //Update the text
            displayText.text = "X: " + xCoord.ToString("F2") + "\nZ: " + zCoord.ToString("F2");

            //Set the position
            displayText.transform.position = hitObject.transform.position + Vector3.up * 2f;

            //Text visible
            displayText.enabled = true;
        }
        else
        {
            //If no hit then hide the text
            displayText.enabled = false;
        }
    }
}
