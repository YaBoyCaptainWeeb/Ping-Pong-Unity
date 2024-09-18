using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private Rigidbody2D body;
    public float speed = 400.0f;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        ResetPos();
    }

    private void StartingForce()
    {
        float X = Random.value < 0.5f ? -1.0f : 1.0f;
        float Y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);

        body.AddForce(new Vector2(X, Y) * speed);
    }

    public void AddForce(Vector2 force)
    {
        body.AddForce(force);
    }

    public void ResetPos()
    {
        body.position = Vector2.zero;
        body.velocity = Vector2.zero;

        StartingForce();
    }
}
