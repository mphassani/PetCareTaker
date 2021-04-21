using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarPointScript : MonoBehaviour
{
    public int pointPillar;

    // Start is called before the first frame update
    void Start()
    {
        pointPillar = 0;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entered collision");
        if (other.gameObject.CompareTag ("ScorePillar"))
        {
            Debug.Log("Entered Tag");
            other.gameObject.SetActive (false);
            pointPillar++;

        }
    }
}
