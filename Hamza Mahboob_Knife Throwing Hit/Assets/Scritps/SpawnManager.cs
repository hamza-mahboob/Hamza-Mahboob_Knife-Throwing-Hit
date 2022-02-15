using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject player;
    public GameObject playerPlaceHolder;
    GameObject tempPlaceHolder;
    GameManager gameManager;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //getting time to stop spam of knifes
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && time > 1)
        {
            time = 0;
            if (gameManager.hasKnife())
            {
                //throw a knife and reduce the number of knives
                Instantiate(player);
                gameManager.reduceKnife();
            }

            //place holder for knife
            if(tempPlaceHolder != null)
                Destroy(tempPlaceHolder);
        }
    }

    public void SpawnPlaceHolder()
    {
        tempPlaceHolder = Instantiate(playerPlaceHolder);
    }
}
