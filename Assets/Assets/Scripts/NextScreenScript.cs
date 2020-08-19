using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScreenScript : MonoBehaviour
{
    Vector3 cameraPosition;
    Vector3 playerPosition;
    public bool goRight;

    // Start is called before the first frame update
    void Start()
    {
        goRight = true;
        //cameraPosition = PlayerController.instance.roomCamera.transform.position;
        playerPosition = PlayerController.instance.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (goRight == true)
            {
                goRight = false;
                cameraPosition.x += 18f;
                //PlayerController.instance.roomCamera.transform.position = cameraPosition;
                playerPosition = PlayerController.instance.transform.position;
                playerPosition.x += 1.5f;
                PlayerController.instance.transform.position = playerPosition;
            }
            else
            {
                goRight = true;
                cameraPosition.x -= 18f;
                //PlayerController.instance.roomCamera.transform.position = cameraPosition;
                playerPosition = PlayerController.instance.transform.position;
                playerPosition.x -= 1.5f;
                PlayerController.instance.transform.position = playerPosition;
            }
        }
    }
}
