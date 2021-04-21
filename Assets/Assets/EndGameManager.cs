using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class EndGameManager : MonoBehaviour
{
    public static float speedMultiplier = 1f;

    public static int level = 1;
    public static int highScoreTracker = 0;
    public static int scoreTracker = 0;

    public static int pins;
    private static int currentPins;

    public float speedRangeMinimum = 0;
    public float speedRangeMaximum = 0;

    public static float coinKeeper = 0;

    public AudioSource GameWonSound;

    // Start is called before the first frame update
    void Start()
    {
        currentPins = pins;
        pins += 2;
    }

    void Update()
    {
        if (pins <= 0)
        {
            scoreTracker = level;
            GameWon();
        }
        if(pins > 12)
        {
            pins = 12;
        }
        //Debug.Log("Level: " + level);
        //Debug.Log("Number of Pins: " + pins);

        Debug.Log(coinKeeper);

    }
    public void GameWon()
    {
        GameWonSound.Play();
        if(level > highScoreTracker)
        {
            highScoreTracker = level;
        }
        pins = currentPins + 2;
        level++;
        coinKeeper++;
        float negativeSetter = Random.Range(0f, 1f);

        if (negativeSetter > 0.5)
            speedMultiplier = (Random.Range(speedRangeMinimum, speedRangeMaximum));
        else if (negativeSetter < 0.5)
            speedMultiplier = -(Random.Range(speedRangeMinimum, speedRangeMaximum));

        //Debug.Log("Range: " + negativeSetter);
        SceneManager.LoadScene(3);
    }

    public void GameLoss()
    {
        pins = 2;
        level = 1;
        speedMultiplier = 1f;
        SceneManager.LoadScene(1);
    }
}