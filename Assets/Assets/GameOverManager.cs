using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public Text HighScore;
    public Text Score;
    public Button PlayAgain;
    public Button MainMenu;

    public AudioSource MenuClick;

    // Start is called before the first frame update
    void Start()
    {
        PlayAgain.onClick.AddListener(TaskOnClickPlayAgain);
        MainMenu.onClick.AddListener(TaskOnClickMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        HighScore.text = "High Score: " + EndGameManager.highScoreTracker;
        Score.text = "Score: " + EndGameManager.scoreTracker;
    }

    public void TaskOnClickPlayAgain()
    {
        MenuClick.Play();
        SceneManager.LoadScene(3);
    }
    public void TaskOnClickMainMenu()
    {
        MenuClick.Play();
        SceneManager.LoadScene(0);
    }
}
