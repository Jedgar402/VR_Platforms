using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPuzzle : MonoBehaviour
{
    public string desiredTag;

    public bool isCorrect;

    // Start is called before the first frame update
    void Start()
    {
        isCorrect = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other != null) 
        { 
            if (other.gameObject.CompareTag(desiredTag))
            {
                isCorrect = true;
            }
        }
    }
}
