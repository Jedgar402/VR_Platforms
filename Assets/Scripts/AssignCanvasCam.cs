using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignCanvasCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Canavs object
        Canvas canvas = GetComponent<Canvas>(); 

        //If there is as canvas and there is no assigned world cam
        if (canvas && canvas.worldCamera == null)
        {
            //Assign the canvas cam to the main cam in the scene
            canvas.worldCamera = Camera.main;
        }
    }
}
