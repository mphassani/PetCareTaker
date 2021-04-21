using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NeedleSpawner : MonoBehaviour
{
    public GameObject prefab;
    private bool hasTouched = false;
    public float fireRate = 1f;
    private float nextFire;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            while ((Input.touchCount > 0 && hasTouched == false) && Time.time > nextFire)
            {

                Instantiate(prefab, transform.position, transform.rotation);
                nextFire = Time.time + fireRate;
                hasTouched = true;
            }

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
            {
                hasTouched = false;
            }

    }
}
