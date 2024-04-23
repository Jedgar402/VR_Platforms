using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GazeInteractiveObject : MonoBehaviour
{
    public Text gazedText;

    public string gazedString;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnGazeEnter()
    {
        gazedText.text = gazedString;
    }

    public void OnGazeExit()
    {
        gazedText.text = "";
    }
}
