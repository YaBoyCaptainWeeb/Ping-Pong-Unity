using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAccelerator : MonoBehaviour
{
    public float BounceStrength = 10.0f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BallBehavior ball = collision.gameObject.GetComponent<BallBehavior>();

        if (ball != null)
        {
            Vector2 normal = -collision.GetContact(0).normal;
            ball.AddForce(normal * BounceStrength);
        }
    }
}
