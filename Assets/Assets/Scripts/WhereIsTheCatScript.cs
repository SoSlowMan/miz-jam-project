using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WhereIsTheCatScript : MonoBehaviour
{
    public GameObject[] chests;
    public int catChestNum;
    public GameObject catChest;
    public float distanceCatChest;
    public SpriteRenderer staff;
    public float distanceColor;
    public int amountOfChests;
    public string currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        catChestNum = Random.Range(0,amountOfChests);
        chests[catChestNum].name = "catChest";
        catChest = GameObject.Find("catChest");
        currentLevel = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        distanceCatChest = Vector3.Distance(catChest.transform.position, PlayerController.instance.transform.position);
        distanceColor = distanceCatChest/3 - 0.6f;
        switch (currentLevel)
        {
            case "SampleScene":
                staff.color = Color.yellow * (1 - distanceColor);
                break;
            case "level2":
                staff.color = Color.yellow * (1 - distanceColor);
                break;
            case "level3":
                staff.color = Color.yellow * (1 - distanceColor);
                break;
            case "level4":
                staff.color = Color.green * (1 - distanceColor);
                break;
            case "level5":
                staff.color = Color.green * (1 - distanceColor);
                break;
        }
    }
}
