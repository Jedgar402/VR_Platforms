using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public TextMeshPro scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        UpdateText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            score++;

            UpdateText();

            Destroy(other);
        }
    }

    private void UpdateText()
    {
        scoreText.text = "Score: " + score;
    }
}
