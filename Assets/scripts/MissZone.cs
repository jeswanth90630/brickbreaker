using UnityEngine;

public class MissZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (GameManager.instance != null)
            {
                GameManager.instance.Miss();
            }
            else
            {
                Debug.LogError("GameManager.instance is null. Make sure GameManager is in the scene and loaded before the ball hits the miss zone.");
            }
        }
    }
}
