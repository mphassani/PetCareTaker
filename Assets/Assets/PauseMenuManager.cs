using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuManager : MonoBehaviour
{
    public Button PauseMenu;
    public GameObject Continue;
    public GameObject MainMenu;
    public GameObject BlackScreen;

    public AudioSource audio;

    public static bool isPauseMenu = false;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.onClick.AddListener(TaskOnClickPause);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClickPause()
    {
        audio.Play();
        isPauseMenu = true;
        Time.timeScale = 0;
        Continue.SetActive(true);
        MainMenu.SetActive(true);
        BlackScreen.SetActive(true);
        
    }

    public void TaskOnClickContinue()
    {
        audio.Play();
        isPauseMenu = false;
        Time.timeScale = 1;
        Continue.SetActive(false);
        MainMenu.SetActive(false);
        BlackScreen.SetActive(false);
    }

    public void TaskOnClickMainMenu()
    {
        audio.Play();
        isPauseMenu = false;
        Time.timeScale = 1;
        BlackScreen.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
