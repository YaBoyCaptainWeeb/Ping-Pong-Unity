using UnityEngine;
using System;

public class Player2Paddle : Paddle
{
    public Rigidbody2D TargettedBall;
    private void FixedUpdate()
    {
        if (TargettedBall.velocity.x > 0.0f)
        {
            if (TargettedBall.position.y > transform.position.y)
            {
                body.AddForce(Vector2.up * speed);
            } else if (TargettedBall.position.y < transform.position.y)
            {
                body.AddForce(Vector2.down * speed);
            }
        } else if (TargettedBall.velocity.x < 0.0f)
        {
            if (transform.position.y > 0.0f)
            {
                body.AddForce(Vector2.down * speed);
            }
            else if (transform.position.y < 0.0f)
            {
                body.AddForce(Vector2.up * speed);
            }
        }
    }
}
