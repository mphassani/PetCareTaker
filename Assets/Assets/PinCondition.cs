using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PinCondition : MonoBehaviour
{
    public float speed = 0f;
    private Rigidbody2D objectRigidBody;

    private bool stopMovement = false;

    // Start is called before the first frame update
    void Start()
    {
        objectRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PauseMenuManager.isPauseMenu)
            Destroy(GameObject.FindWithTag("Unlanded"));

        float step = speed * Time.deltaTime;
        if (stopMovement == false)
            transform.position = Vector3.MoveTowards(transform.position, GameObject.FindGameObjectWithTag("circle").transform.position, step);
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if(collision.tag == "circle")
        {
            transform.gameObject.tag = "needle";
            EndGameManager.pins--;
            transform.SetParent(collision.transform);
            objectRigidBody.MovePosition(objectRigidBody.position + Vector2.up * speed * Time.deltaTime);
            stopMovement = true;
        }
        else if(collision.tag == "needle")
        {
            FindObjectOfType<EndGameManager>().GameLoss();
        }
    }
}
