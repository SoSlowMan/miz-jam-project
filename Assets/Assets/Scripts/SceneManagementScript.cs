using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagementScript : MonoBehaviour
{
    public string currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(currentLevel);
    }

    public void StartTheGame()
    {
        SceneManager.LoadScene("StartCutScene");
    }

    public void ExitTheGame()
    {
        Application.Quit();
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
