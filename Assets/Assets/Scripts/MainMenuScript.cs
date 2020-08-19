using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject howToPlay;
    // Start is called before the first frame update
    void Start()
    {
        howToPlay.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void openHelp()
    {
        howToPlay.SetActive(true);
    }

    public void closeHelp()
    {
        howToPlay.SetActive(false);
    }
}
