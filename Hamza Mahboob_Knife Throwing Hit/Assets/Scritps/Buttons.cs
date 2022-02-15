using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void RestartBTN()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }

    public void PlayBTN()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScene");
    }
    public void MainMenuBTN()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
