using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] float timeDelay = 2f;

    private void Start()
    {
        Screen.SetResolution(1080, 1920, true);   
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }
    
    public void LoadGameOverScene()
    {
        StartCoroutine(DelayLoad());
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator DelayLoad()
    {
        yield return new WaitForSeconds(timeDelay);
        SceneManager.LoadScene("Game Over");
    }
}

