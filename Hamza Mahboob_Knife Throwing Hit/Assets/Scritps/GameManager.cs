using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoreTXT, knivesTXT;
    public GameObject gameOverScreen;
    public GameObject congratulationsScreen;
    int knife, score;
    // Start is called before the first frame update
    void Start()
    {
        knife = 7;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        knivesTXT.text = knife.ToString();
        scoreTXT.text = score.ToString();
    }

    public bool hasKnife()
    {
        if(knife > 0)
            return true;
        return false;
    }

    public void reduceKnife()
    {
        knife--;
    }

    public void addScore()
    {
        score += 10;
    }

    public void GameOverScreen()
    {
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;
    }

    public void CongratulationsScreen()
    {
        congratulationsScreen.SetActive(true);
        Time.timeScale = 0;
    }
}
