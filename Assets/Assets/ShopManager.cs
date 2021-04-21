using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClickBuy()
    {
        if(CoinDisplay.coins >= 300)
        {
            audio.Play();
            PowerUpManager.numOfPowerUps++;
            CoinDisplay.coins -= 300;
        }
        else
        {
            Debug.Log("Not enough money");
        }

    }

    public void TaskOnClickBack()
    {
        audio.Play();
        SceneManager.LoadScene(0);
    }
}
