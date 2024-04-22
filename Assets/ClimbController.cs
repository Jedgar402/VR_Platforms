using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClimbController : MonoBehaviour
{
    public GameObject xrRig;

    // Start is called before the first frame update
    void Start()
    {
        if (xrRig == null)
        {
            xrRig = GameObject.Find("XR Rig");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Grab()
    {

    }

    public void Pull(Vector3 distance)
    { 
        xrRig.transform.Translate(distance); 
    }

    public void Release()
    {

    }       
}
