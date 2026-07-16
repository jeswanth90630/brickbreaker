using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class LevelCompletedUI : MonoBehaviour
{
    [Header("UI References")]
    public GameObject uiPanel;
    public TMP_Text levelText;
    public TMP_Text scoreText;
    public Button restartButton;
    public Button nextLevelButton;
    public Button exitButton;

    void Start()
    {
        if (uiPanel != null)
            uiPanel.SetActive(false);

        if (restartButton != null)
            restartButton.onClick.AddListener(OnRestartButtonClick);
        else
            Debug.LogWarning("Restart button is not assigned.");

        if (nextLevelButton != null)
            nextLevelButton.onClick.AddListener(OnNextLevelButtonClick);
        else
            Debug.LogWarning("Next level button is not assigned.");

        if (exitButton != null)
            exitButton.onClick.AddListener(OnExitButtonClick);
        else
            Debug.LogWarning("Exit button is not assigned.");
    }

    public void Show(int score)
    {
        if (uiPanel != null)
            uiPanel.SetActive(true);

        if (GameManager.instance != null && GameManager.instance.lives <= 0)
        {
            levelText.text = "GAME OVER";
            nextLevelButton.gameObject.SetActive(false);
        }
        else
        {
            levelText.text = "LEVEL COMPLETE!";
            nextLevelButton.gameObject.SetActive(true);
        }

        if (exitButton != null)
            exitButton.gameObject.SetActive(true);

        if (scoreText != null)
            scoreText.text = "SCORE: " + score.ToString();

        Time.timeScale = 0;
    }

    public void Hide()
    {
        if (uiPanel != null)
            uiPanel.SetActive(false);

        if (exitButton != null)
            exitButton.gameObject.SetActive(false);

        Time.timeScale = 1;
    }

    private void OnRestartButtonClick()
    {
        if (GameManager.instance != null)
        {
            GameManager.instance.score = 0;
            GameManager.instance.lives = 3;

            if (GameManager.instance.lives <= 0)
                GameManager.instance.RestartGame(); // Optional
            else
                GameManager.instance.RestartCurrentLevel();
        }
        else
        {
            Debug.LogWarning("GameManager.instance is null. Reloading current scene.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        }
    }

    private void OnNextLevelButtonClick()
    {
        if (GameManager.instance != null)
        {
            Time.timeScale = 1;

            int nextLevel = GameManager.instance.level + 1;
            string nextSceneName = "Level" + nextLevel;

            if (Application.CanStreamedLevelBeLoaded(nextSceneName))
            {
                GameManager.instance.level = nextLevel;

                // ✅ Reset score/lives after Level 1
                if (nextLevel == 2)
                {
                    GameManager.instance.score = 0;
                    GameManager.instance.lives = 3;
                }

                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                Debug.LogWarning("Scene " + nextSceneName + " not found in build settings.");
            }
        }
        else
        {
            Debug.LogWarning("GameManager.instance is null. Loading fallback Level2.");
            SceneManager.LoadScene("Level2");
            Time.timeScale = 1;
        }
    }

    private void OnExitButtonClick()
    {
        Time.timeScale = 1;

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
