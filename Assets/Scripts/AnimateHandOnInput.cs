using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{
    // Reference to the pinch animation input action
    public InputActionProperty pinchAnimation;

    // Reference to the grip animation input action
    public InputActionProperty gripAnimation;

    // Reference to the animator component controlling hand animations
    public Animator handAnim;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Read the value of the pinch animation input action
        float pinchValue = pinchAnimation.action.ReadValue<float>();

        // Set the "Trigger" parameter in the animator to the pinch value
        handAnim.SetFloat("Trigger", pinchValue);

        // Read the value of the grip animation input action
        float gripValue = gripAnimation.action.ReadValue<float>();

        // Set the "Grip" parameter in the animator to the grip value
        handAnim.SetFloat("Grip", gripValue);

        // Log the pinch value for debugging purposes
        Debug.Log(pinchValue);
    }
}