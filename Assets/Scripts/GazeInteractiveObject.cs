using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GazeInteractiveObject : MonoBehaviour
{
    //Ref to the ui text
    public Text gazedText;
    //Contents of text
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
        //On ray cast enter
        //Output this objects text
        gazedText.text = gazedString;
    }

    public void OnGazeExit()
    {
        //On ray cast exit
        //Remove text
        gazedText.text = "";
    }
}
