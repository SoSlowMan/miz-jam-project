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

    // Start is called before the first frame update
    void Start()
    {
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (name == "catChest")
                {
                    PlayerController.instance.catFound = true;
                    catPic.SetActive(true);
                    chestPic.SetActive(false);
                }
                else
                {
                    chestPic.SetActive(false);
                    randomPic.SetActive(true);
                    PlayerController.instance.apocalypseTimer = PlayerController.instance.apocalypseTimer + 100;
                }
            }
        }
    }
}
