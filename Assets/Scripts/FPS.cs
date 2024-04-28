using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS : MonoBehaviour
{
    //Variable for time between frames
    float deltaTime = 0.0f;
    //Text appearance
    GUIStyle style;

    // Start is called before the first frame update
    void Start()
    {
        //initalize new GUI
        style = new GUIStyle();
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = 20;
        style.normal.textColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate time between frames
        deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        //Get the screen size
        int w = Screen.width, h = Screen.height;
        //Set up a Rect to position text
        Rect rect = new Rect(0, 0, w, h * 2 / 100);
        //Set properties
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 50;
        //Display frames per second
        GUI.Label(rect, string.Format("{0:0.} FPS", 1.0f / deltaTime), style);
    }
}
