using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Ball ball { get; private set; }
    public Paddle paddle { get; private set; }
    public Brick[] bricks { get; private set; }

    public int level = 1;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            SceneManager.sceneLoaded += OnLevelLoaded;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnLevelLoaded;
    }

    private void Start()
    {
        LoadLevel(1);
    }

    private void NewGame()
    {
        score = 0;
        lives = 3;
        LoadLevel(1);
    }

    private void LoadLevel(int level)
    {
        this.level = level;
        SceneManager.LoadScene("Level" + level);
    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        ball = FindFirstObjectByType<Ball>();
        paddle = FindFirstObjectByType<Paddle>();
        bricks = FindObjectsByType<Brick>(FindObjectsSortMode.None);
    }

    private void ResetLevel()
    {
        if (ball != null) ball.ResetBall();
        if (paddle != null) paddle.ResetPaddle();
    }

    private void GameOver()
    {
        Time.timeScale = 0;

        LevelCompletedUI ui = FindAnyObjectByType<LevelCompletedUI>();
        if (ui != null)
        {
            ui.Show(score);
        }
        else
        {
            Debug.LogWarning("LevelCompletedUI not found at GameOver.");
        }
    }

    public void Miss()
    {
        lives--;

        if (lives > 0)
        {
            ResetLevel();
        }
        else
        {
            GameOver();
        }
    }

    public void Hit(Brick brick)
    {
        score += brick.points;

        if (AllBricksCleared())
        {
            Time.timeScale = 0;

            LevelCompletedUI ui = FindAnyObjectByType<LevelCompletedUI>();
            if (ui != null)
            {
                ui.Show(score);
            }
            else
            {
                Debug.LogWarning("LevelCompletedUI not found.");
            }
        }
    }

    private bool AllBricksCleared()
    {
        foreach (var brick in bricks)
        {
            if (brick != null && !brick.unbreakable && brick.gameObject.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        NewGame();
    }

    // ✅ NEW: Restart current level only (does not reset score/lives)
    public void RestartCurrentLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level" + level);
    }

    // ✅ NEW: Load next level (can be called from UI)
    public void LoadNextLevel()
    {
        Time.timeScale = 1;
        level += 1;
        SceneManager.LoadScene("Level" + level);
    }
}
