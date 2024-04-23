using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestory : MonoBehaviour
{
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        audio.Play();
    }
}
