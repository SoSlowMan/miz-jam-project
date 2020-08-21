using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestScript : MonoBehaviour
{
    public float playerRange;
    public GameObject tutorial;
    public GameObject chestPic;
    public GameObject catPic;
    public bool catChest;
    public GameObject randomPic;
    public GameObject errorSound;
    public bool isOpened;

    // Start is called before the first frame update
    void Start()
    {
        isOpened = false;
        playerRange = 1.2f;
        catPic.SetActive(false);
        chestPic.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PlayerController.instance.transform.position) < playerRange && PlayerController.instance.hasDied == false)
        {
            //tutorial.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && isOpened == false)
            {
                isOpened = true;
                if (name == "catChest")
                {
                    AudioController.instance.levelMusic.Stop();
                    AudioController.instance.PlayWinSound();
                    PlayerController.instance.catFound = true;
                    catPic.SetActive(true);
                    chestPic.SetActive(false);
                }
                else
                {
                    PlayerController.instance.mistakes += 1;
                    AudioController.instance.PlayErrorSound();
                    chestPic.SetActive(false);
                    randomPic.SetActive(true);
                }
            }
        }
    }
}
