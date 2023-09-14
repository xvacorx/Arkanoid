using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    BallMovement ballMovement;

    private void Start()
    {
        ballMovement = FindObjectOfType<BallMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ballMovement.ChangeBallSpeed(0.5f);
        if (collision.gameObject.CompareTag("Ball"))
        {
            Destroy(gameObject);
        }
    }
}