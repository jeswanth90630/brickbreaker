using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    void Start()
    {
        if (GameManager.instance != null)
        {
            scoreText.text = "Final Score: " + GameManager.instance.score;
        }
        else
        {
            scoreText.text = "No score available";
        }
    }
}
