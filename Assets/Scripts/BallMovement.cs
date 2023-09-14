using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Rigidbody2D BallRgb;
    private float BallSpeed = 5f;
    Vector2 Direction;

    public GameOverScreen screen;
    public WinScreen win;

    void Start()
    {
        Direction.x = Random.Range(1.5f, -1.5f);
        Direction.y = 1;
        BallRgb.AddForce(BallSpeed * Direction);
    }

    private void FixedUpdate()
    {
        Vector2 Direction = BallRgb.velocity.normalized;
        BallRgb.velocity = Direction * BallSpeed;
        GameObject[] bricks = GameObject.FindGameObjectsWithTag("Brick");
        if (bricks.Length == 0) { win.ActiveScreen(); }
    }

    public void ChangeBallSpeed(float speed)
    {
        BallSpeed = BallSpeed + speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lose"))
        {
            screen.ActiveScreen();
        }
    }
}