using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsController : MonoBehaviour
{
    // Ref to the settings menu
    public GameObject settingsMenu;
    // Ref to the pause Menu
    public GameObject pauseMenu;

    private bool inSettings = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleSettingsMenu()
    {
        // Toggle the settings state
        inSettings = !inSettings;

        if (inSettings)
        {
            pauseMenu.SetActive(false);
            // Show the settings menu
            settingsMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(true);
            // Hide the settings menu
            settingsMenu.SetActive(false);
        }
    }
}
