using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject howToPlay;
    // Start is called before the first frame update
    void Start()
    {
        AudioController.instance.PlayMainMenuMusic();
        PlayerPrefs.DeleteKey("saveLevel1");
        PlayerPrefs.DeleteKey("saveLevel2");
        PlayerPrefs.DeleteKey("saveLevel3");
        PlayerPrefs.DeleteKey("saveLevel4");
        PlayerPrefs.DeleteKey("saveLevel5");
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
