using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CircleSpinner : MonoBehaviour
{
    public float turnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        turnSpeed = 1.2f * EndGameManager.speedMultiplier;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        transform.Rotate(0, 0, turnSpeed, Space.Self);
        Debug.Log("Turn Speed: " + turnSpeed);
    }
}
