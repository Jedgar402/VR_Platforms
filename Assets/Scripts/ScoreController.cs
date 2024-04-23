using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text coinsText;
    private int coins = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            coins++;

            UpdateText();

            Destroy(other);
        }
    }

    private void UpdateText()
    {
        coinsText.text = "Score: " + coins;
    }
}
