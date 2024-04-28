using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallHoops : MonoBehaviour
{

    public ScoreController currentScore;

    public GameObject ball;

    public Transform spawn;

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
        if(other.gameObject.CompareTag("Ball"))
        {
            currentScore.coins++;

            Destroy(other, 1.5f);

            Instantiate(ball, spawn);
        }
    }
}
