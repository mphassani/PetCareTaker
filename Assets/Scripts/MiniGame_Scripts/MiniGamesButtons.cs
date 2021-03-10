using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamesButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenuButton()
    {
        Application.LoadLevel(0);
    }
    public void FlappyButton()
    {
        Application.LoadLevel(2);
    }
}
