using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    // Ref to the pause menu
    public GameObject pauseMenuUI; 
    // Ref to the pauseMenu
    public GameObject HUD;

    private bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        DefaultUI();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("XRI_Left_MenuButton"))
        {
            TogglePauseMenu();
        }
    }

    public void TogglePauseMenu()
    {
        // Toggle the pause state
        isPaused = !isPaused; 

        if (isPaused)
        {
            HUD.SetActive(false);
            // Show the pause menu
            pauseMenuUI.SetActive(true); 
        }
        else
        {
            HUD.SetActive(true);
            // Hide the pause menu
            pauseMenuUI.SetActive(false); 
        }
    }

    private void DefaultUI()
    {
        HUD.SetActive(true);
        
        pauseMenuUI.SetActive(false);
    }
}
