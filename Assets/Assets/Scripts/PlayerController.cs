using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //singleton
    public static PlayerController instance;

    public float moveSpeed;

    private Vector2 moveInput;
    public Rigidbody2D theRB;

    public bool hasDied;
    public bool catFound;

    public GameObject deadScreen;
    public GameObject winScreen;
    public GameObject startScreen;
    public GameObject pressSpace;
    public GameObject timer;

    public float deathClock;
    public float apocalypseTimer;
    public float apocalypseTimer100;
    public float startTime;

    public string currentLevel;
    public string nextLevel;
    public bool isLevelStarted;

    //public GameObject roomCamera;

    private Animator anim;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        hasDied = false;
        anim = GetComponent<Animator>();
        currentLevel = SceneManager.GetActiveScene().name;
        isLevelStarted = false;
        switch (currentLevel)
        {
            case "SampleScene":
                nextLevel = "level2";
                break;
            case "level2":
                nextLevel = "level3";
                break;
            case "level3":
                nextLevel = "level4";
                break;
            case "level4":
                nextLevel = "level5";
                break;
            case "level5":
                nextLevel = "EndingScreen";
                break;
        }
     }

    // Update is called once per frame
    void Update()
    {
        if (hasDied == false)
        {
            if (isLevelStarted == false)
            {
                pressSpace.SetActive(true);
                timer.SetActive(false);
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    isLevelStarted = true;
                    startTime = Time.timeSinceLevelLoad;
                    pressSpace.SetActive(false);
                    timer.SetActive(true);
                }             
            }
            else
            {
                moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
                Vector3 moveHorizontal = transform.up * moveInput.y;
                Vector3 moveVertical = transform.right * moveInput.x;
                theRB.velocity = (moveHorizontal + moveVertical) * moveSpeed;// * Time.deltaTime; doesn't work on some PC's, idk why
                anim.SetFloat("MoveX", Input.GetAxis("Horizontal"));
                apocalypseTimer = (Time.timeSinceLevelLoad - startTime);// * 100;
                apocalypseTimer100 = apocalypseTimer * 100;
                if (catFound == true)
                {
                    //make switches
                    switch (currentLevel)
                    {
                        case "SampleScene":
                            PlayerPrefs.SetFloat("saveLevel1", apocalypseTimer);
                            break;
                        case "level2":
                            PlayerPrefs.SetFloat("saveLevel2", apocalypseTimer);
                            break;
                        case "level3":
                            PlayerPrefs.SetFloat("saveLevel3", apocalypseTimer);
                            break;
                        case "level4":
                            PlayerPrefs.SetFloat("saveLevel4", apocalypseTimer);
                            break;
                        case "level5":
                            PlayerPrefs.SetFloat("saveLevel5", apocalypseTimer);
                            break;
                    }
                    startScreen.SetActive(false);
                    winScreen.SetActive(true);
                    apocalypseTimer100 = -999999;
                    if (Input.GetKeyDown(KeyCode.Space))
                    {
                        SceneManager.LoadScene(nextLevel);
                    }
                }
                if (apocalypseTimer100 > deathClock)
                {
                    hasDied = true;
                }
            }
        }
        else
        {
            startScreen.SetActive(false);
            deadScreen.SetActive(true);
        }
    }
}
