using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerPlaceHolder;
    public SpawnManager spawnManager;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager=GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Obstacle Hit");

            //stick to obstacle by making knife child of sphere
            GetComponent<MoveForward>().enabled = false;
            gameObject.transform.SetParent(other.gameObject.transform);

            //spawn placeholder
            spawnManager.SpawnPlaceHolder();
            gameManager.addScore();

            if (!gameManager.hasKnife())
                gameManager.CongratulationsScreen();
        }

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Knife"))
        {
            //game over if one knife hits another knife
            Debug.Log("ANOTHER KNIFE?");
            gameManager.GameOverScreen();
        }
    }
}
