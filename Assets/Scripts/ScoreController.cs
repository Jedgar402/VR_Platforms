using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    //Ref to ui text 
    public Text coinsText;
    //Ref to player score
    public int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Update the score on start
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        //If the player enters coin trigger
        if(other.gameObject.CompareTag("Coin"))
        {
            //Add coin
            coins++;
            //Update text
            UpdateText();
        }
    }

    private void UpdateText()
    {
        //Update ui text with coin score
        coinsText.text = "Score: " + coins;
    }
}
