using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocomotionGliding : MonoBehaviour
{
    // Reference to the root transform of the rig.
    public Transform rigRoot;
    // Speed of gliding locomotion.
    public float velocity = 2f;
    // Speed of rotation.
    public float rotationSpeed = 50f;
    // Flag to indicate if the player is currently moving.
    public bool isMoving;
    //Transform to track direction the player is facing
    public Transform trackingTransform;

    // Start is called before the first frame update.
    void Start()
    {
        if (rigRoot == null)
        {
            rigRoot = this.transform;
        }
    }

    // Update is called once per frame.
    void Update()
    {
        // Forward input from player thumbstick
        float forward = Input.GetAxis("XRI_Right_Primary2DAxis_Vertical");
        //If there is an input
        if (forward != 0f)
        {
            //This input is hte direction magnitude 
            Vector3 moveDirection = Vector3.forward;
            //If the trackingTransform exists
            if (trackingTransform != null)
            {
                //The trackinTransform forward vector is the moveDirection
                moveDirection = trackingTransform.forward;
                moveDirection.y = 0f;
            }
            //The moveDirection is the forward direction times the velcity speed every second
            moveDirection *= forward * velocity * Time.deltaTime;
            //Translate the rigRoot to the moveDireciton
            rigRoot.Translate(moveDirection);
        }

        //Side input from the players thumbstick
        float sideways = Input.GetAxis("XRI_Left_Primary2DAxis_Horizontal");
        //If there is an input
        if (sideways != 0f)
        {
            //Rotation is equal to the side input times the rotation speed every second
            float rotation = sideways * rotationSpeed * Time.deltaTime;
            //Rotate the rigRoot 
            rigRoot.Rotate(0, rotation, 0);
        }
    }
}