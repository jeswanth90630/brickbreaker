using UnityEngine;

public class Brick : MonoBehaviour
{
    public SpriteRenderer spriteRenderer { get; private set; }
    public Sprite[] states;
    public int health { get; private set; }
    public int points = 100;
    public bool unbreakable;

    public AudioClip hitSound;   // assign in Inspector
    public AudioClip breakSound; // assign in Inspector

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        ResetBrick();
    }

    public void ResetBrick()
    {
        gameObject.SetActive(true);

        if (!unbreakable)
        {
            health = states.Length;
            spriteRenderer.sprite = states[health - 1];
        }
    }

    private void Hit()
    {
        if (unbreakable)
        {
            PlaySound(hitSound);
            return;
        }

        health--;

        if (health <= 0)
        {
            PlaySound(breakSound);
            gameObject.SetActive(false);
        }
        else
        {
            PlaySound(hitSound);
            spriteRenderer.sprite = states[health - 1];
        }

        if (GameManager.instance != null)
        {
            GameManager.instance.Hit(this);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ball")
        {
            Hit();
        }
    }

    private void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            // Use global playback to ensure sound plays even if object is destroyed
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}
