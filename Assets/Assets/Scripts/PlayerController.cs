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

    public float deathClock;
    public float apocalypseTimer;

    public string currentLevel;
    public string nextLevel;

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
                nextLevel = "MainMenu";
                break;
        }
     }

    // Update is called once per frame
    void Update()
    {
        if (hasDied == false)
        {
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector3 moveHorizontal = transform.up * moveInput.y;
            Vector3 moveVertical = transform.right * moveInput.x;
            theRB.velocity = (moveHorizontal + moveVertical) * moveSpeed;// * Time.deltaTime; doesn't work on some PC's, idk why
            anim.SetFloat("MoveX",Input.GetAxis("Horizontal"));
            apocalypseTimer = Time.timeSinceLevelLoad * 100;
            if (catFound == true)
            {
                //make switches
                startScreen.SetActive(false);
                winScreen.SetActive(true);
                apocalypseTimer = -999999;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene(nextLevel);
                }
            }
            if (apocalypseTimer > deathClock)
            {
                hasDied = true;
            }

        }
        else
        {
            startScreen.SetActive(false);
            deadScreen.SetActive(true);
        }
    }
}
