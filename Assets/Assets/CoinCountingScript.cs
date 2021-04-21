using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountingScript : MonoBehaviour
{
    public Text text;
    float counter = 0f;
    public float increaseRate;
    float score = 0;
    float max;
    // Start is called before the first frame update
    void Start()
    {
        max = EndGameManager.coinKeeper * 30;
        CoinDisplay.coins += (int)max;
        EndGameManager.coinKeeper = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "+" + (int)score;

        if(score < max)
        {
            counter = Time.deltaTime * increaseRate;
            score += counter;
        }
        if(score == max)
        {
            score = (int)max;
        }
    }
}
