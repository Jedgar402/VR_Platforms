using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //Ref to shadows toggle
    public Toggle shadowsToggle;
    //Ref to volume slider
    public Slider volumeSlider;
    //Ref for audio source
    public AudioSource audio;
    //Default shadows bool
    private bool shadowsEnabled = false;
    private XRController xrController;

    private void Start()
    {
        //Toggle shados
        shadowsToggle.isOn = shadowsEnabled;

        //Check is toggle has changed the bool
        if (shadowsEnabled)
        {
            // Disable shadows
            QualitySettings.shadows = ShadowQuality.Disable;
        }
        else
        {
            // Enable shadows
            QualitySettings.shadows = ShadowQuality.All;
        }

        //Set initial volume slider value
        //volumeSlider.value = audio.volume;
    }

    private void Update()
    {
        //Check if the trigger is pressed
        if (Input.GetButtonDown("XRI_Left_TriggerButton") ||
            Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            //Raycast from the controller
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                //Switch statement based on the tag of the hit object
                switch (hit.collider.gameObject.tag)
                {
                    case "Quit":
                        QuitApplication();
                        break;
                    case "ShadowsToggle":
                        ToggleShadows();
                        break;
                    case "VolumeSlider":
                        SetVolume(hit.point.y);
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public void SetVolume(float yPosition)
    {
        //Calculate volume based on the slider's position
        float normalizedValue = Mathf.Clamp01((yPosition - volumeSlider.transform.position.y) / volumeSlider.transform.localScale.y);
        audio.volume = normalizedValue;
        volumeSlider.value = normalizedValue;
    }

    public void ToggleShadows()
    {
        //Toggle shadows state
        shadowsEnabled = !shadowsEnabled; 

        shadowsToggle.isOn = shadowsEnabled;

        if (shadowsEnabled)
        {
            //Disable shadows
            QualitySettings.shadows = ShadowQuality.Disable;
        }
        else
        {
            //Enable shadows
            QualitySettings.shadows = ShadowQuality.All;
        }
    }

    //Method to quit the application
    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
