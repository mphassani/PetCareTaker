using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    private Pet pet;

    public Image HungerBar;
    public Image HappinessBar;
    public Image CleanslinessBar;

    // Start is called before the first frame update
    void Start()
    {
        pet = GameObject.FindGameObjectWithTag("Pet").GetComponent<Pet>();
    }

    // Update is called once per frame
    void Update()
    {
        updateStats();
    }

    private void updateStats() {

    }
}
