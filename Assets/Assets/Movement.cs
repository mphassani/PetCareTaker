using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0f;
    public bool stopMovement;
    // Start is called before the first frame update
    void Start()
    {
        stopMovement = false;
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if(stopMovement == false)
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("circle").transform.position, step);
    }
}
