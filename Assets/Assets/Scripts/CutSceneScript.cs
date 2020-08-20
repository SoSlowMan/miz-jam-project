using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutSceneScript : MonoBehaviour
{
    public string currentLevel;
    public string nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        currentLevel = SceneManager.GetActiveScene().name;
        switch (currentLevel)
        {
            case "StartCutScene":
                nextLevel = "SampleScene";
                break;
            case "EndCutScene":
                nextLevel = "EndingScreen";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
