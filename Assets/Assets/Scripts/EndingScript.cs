using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingScript : MonoBehaviour
{
    public float bestTime;
    public float seconds, minutes, miliseconds;
    public Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        AudioController.instance.PlayWinSound();
        bestTime = PlayerPrefs.GetFloat("saveLevel1") + PlayerPrefs.GetFloat("saveLevel2") + PlayerPrefs.GetFloat("saveLevel3") + PlayerPrefs.GetFloat("saveLevel4") + PlayerPrefs.GetFloat("saveLevel5");
    }

    // Update is called once per frame
    void Update()
    {
        minutes = (int)(bestTime / 60f);
        seconds = (int)(bestTime % 60f);
        miliseconds = (int)(((bestTime % 60f) * 100) % 100);
        counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("00");
    }
}
