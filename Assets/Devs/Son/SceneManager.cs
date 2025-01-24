using UnityEngine.SceneManagement;
using UnityEngine;

public class MySceneManager : MonoBehaviour
{

    public static MySceneManager Instance;

    private static int lastMap = 4;

    private void Awake()
    {

        if (
            Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

    }

    // Load the Main Menu scene
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
        SoundManager.instance.PlayBackgroundMusic(0);
    }

    // Load Map 1 scene
    public void LoadMap1()
    {
        SceneManager.LoadScene(1);
        lastMap = 1;
        SoundManager.instance.PlayBackgroundMusic(1);
    }

    // Load Map 2 scene
    public void LoadMap2()
    {
        SceneManager.LoadScene(2);
        lastMap = 2;
        SoundManager.instance.PlayBackgroundMusic(2);
    }

    public void LoadMap3()
    {
        SceneManager.LoadScene(3);
        lastMap = 3;
        SoundManager.instance.PlayBackgroundMusic(3);
    }
    public void LoadPreviousMap()
    {
        SceneManager.LoadScene(lastMap);
    }

    // Load the Map Select scene
    public void LoadMapSelect()
    {
        SceneManager.LoadScene(4);
        SoundManager.instance.PlayBackgroundMusic(4);
    }


    // Load the End Screen scene
    public void LoadEndScreen()
    {
        SceneManager.LoadScene(5);
        SoundManager.instance.PlayBackgroundMusic(5);
    }

    // Load the Settings scene
    public void LoadSettingsScreen()
    {
        SceneManager.LoadScene(6);
    }

    // Load the Rules scene
    public void LoadRulesScreen()
    {
        SceneManager.LoadScene(7);
    }

    // Quit the game
    public void QuitGame()
    {
        Debug.Log("Game is quitting...");
        Application.Quit();

        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
