using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDestory : MonoBehaviour
{
    //Audio source ref
    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if the player enters the coin trigger
        if(other.gameObject.CompareTag("Player"))
        {
            //Destroy this coin
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {
        //On destroy play audio
        audio.Play();
    }
}
