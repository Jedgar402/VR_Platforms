using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGrab : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("XRI_Right_TriggerButton"))
        {
            Debug.Log("Trigger Down");
        }
        else if (Input.GetButtonUp("XRI_Right_TriggerButton"))
        {
            Debug.Log("Trigger Up");
        }
    }
}
