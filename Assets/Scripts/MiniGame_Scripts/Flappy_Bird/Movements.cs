using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 vectorPosition;
    public Transform positionTracker;
    

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   Touch touch = Input.GetTouch(0);
        vectorPosition = Camera.main.ScreenToWorldPoint(new Vector3(0, Input.GetTouch(0).position.y, -1));

        positionTracker.position = new Vector3(positionTracker.position.x, vectorPosition.y, -1);

    }
}
