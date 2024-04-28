using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketBallHoops : MonoBehaviour
{
    //Ref to the score
    public ScoreController currentScore;
    //Ref to the ball prefab
    public GameObject ball;
    //Spawn ppoint of ball
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
        //On ball enters trigger
        if(other.gameObject.CompareTag("Ball"))
        {
            //Increas score
            currentScore.coins++;
            //Destory after delay
            Destroy(other, 1.5f);
            //Spawn new ball
            Instantiate(ball, spawn);
        }
    }
}
