using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public Text HighScore;
    public Button Play;
    public Button Credits;

    public AudioSource MenuClick;
    // Start is called before the first frame update
    void Start()
    {
        Play.onClick.AddListener(TaskOnClickPlay);
        Credits.onClick.AddListener(TaskOnClickCredits);
    }

    // Update is called once per frame
    void Update()
    {

        HighScore.text = "High Score: " + EndGameManager.highScoreTracker;
    }

    public void TaskOnClickPlay()
    {
        MenuClick.Play();
        SceneManager.LoadScene(3);
        
    }

    public void TaskOnClickCredits()
    {
        MenuClick.Play();
        SceneManager.LoadScene(2);
    }

    public void TaskOnClickStore()
    {
        MenuClick.Play();
        SceneManager.LoadScene(4);
    }
}
