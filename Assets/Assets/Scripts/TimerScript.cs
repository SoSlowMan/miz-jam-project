using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public Text counterText;

    public float seconds, minutes, miliseconds;

    public string currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<Text>() as Text;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.instance.isLevelStarted == true)
        {
            minutes = (int)((PlayerController.instance.deathClock) / 6000f - (PlayerController.instance.apocalypseTimer / 60f));
            currentLevel = SceneManager.GetActiveScene().name;
            switch (currentLevel)
            {
                case "SampleScene":
                    seconds = (int)(10 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level2":
                    seconds = (int)(10 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level3":
                    seconds = (int)(15 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level4":
                    seconds = (int)(20 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level5":
                    seconds = (int)(25 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level3_1":
                    seconds = (int)(15 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level4_1":
                    seconds = (int)(20 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
                case "level5_1":
                    seconds = (int)(25 - (PlayerController.instance.apocalypseTimer % 60f));
                    break;
            }
            miliseconds = (int)(100 - (((PlayerController.instance.apocalypseTimer % 60f) * 100) % 100));
            counterText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + miliseconds.ToString("00");
        }
    }
}
