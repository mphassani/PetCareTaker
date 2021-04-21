using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public Text LevelText;
    public Text NeedlesText;

    public AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelText.text = "Level: " + EndGameManager.level;
        NeedlesText.text = "Pins: " + EndGameManager.pins;
    }

    public void TaskOnClickPowerUP()
    {
        Destroy(GameObject.FindWithTag("Unlanded"));
        if (PowerUpManager.numOfPowerUps > 0)
        {
            audio.Play();
            GameObject[] needles = GameObject.FindGameObjectsWithTag("needle");
            for (int i = 0; i < needles.Length; i++)
            {
                Destroy(needles[i]);
            }

            PowerUpManager.numOfPowerUps--;
        }

    }


}
