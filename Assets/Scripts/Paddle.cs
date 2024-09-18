using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D body;
    public float speed = 50.0f;
    protected Vector2 direction;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
}
