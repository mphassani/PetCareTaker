using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounting : MonoBehaviour
{

    public Text m_MyText;
    public GameObject game;

        // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        m_MyText.text = game.GetComponent<PillarPointScript>().pointPillar.ToString();
    }
}
