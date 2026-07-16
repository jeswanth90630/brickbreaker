using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public void OnPlayButtonClick()
    {
        Debug.Log("MainMenuScript: Play button clicked. Loading Level1...");
        SceneManager.LoadScene("Level1");
    }

    public void OnQuitButtonClick()
    {
        Debug.Log("MainMenuScript: Quit button clicked. Exiting application.");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
