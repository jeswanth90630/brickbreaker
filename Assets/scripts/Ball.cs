using UnityEngine;

public class Ball : MonoBehaviour
{
    public new Rigidbody2D rigidbody { get; private set; }

    public float speed = 500f;

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }

    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidbody.linearVelocity = Vector2.zero;

        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = new Vector2(Random.Range(-1f, 1f), -1f).normalized;
        this.rigidbody.linearVelocity = force * speed * Time.fixedDeltaTime;
    }

    private void FixedUpdate()
    {
        // Maintain constant speed
        if (rigidbody.linearVelocity != Vector2.zero)
        {
            rigidbody.linearVelocity = rigidbody.linearVelocity.normalized * speed * Time.fixedDeltaTime;
        }
    }
}
