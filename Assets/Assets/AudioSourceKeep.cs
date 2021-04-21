using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceKeep : MonoBehaviour
{
    public static AudioSourceKeep instance = null;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
        if (instance == null)
        {

            instance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
}
