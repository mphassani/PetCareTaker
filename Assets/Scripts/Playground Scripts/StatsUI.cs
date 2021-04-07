using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    private Pet pet;

    public Text NameText;
    public StatsUIComponent HealthUI;
    public StatsUIComponent HappinessUI;
    public StatsUIComponent HungerUI;
    public Image Picture;

    // Start is called before the first frame update
    void Start()
    {
        HungerUI.SetValueTo(11);
        pet = GameObject.FindGameObjectWithTag("Pet").GetComponent<Pet>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetHealthTo(int value)
    {
        HealthUI.SetValueTo(value);
    }

    public void SetHappinessTo(int value)
    {
        HappinessUI.SetValueTo(value);
    }

    public void SetHungerTo(int value)
    {
        HungerUI.SetValueTo(value);
    }

    public void SetNameTo(string text)
    {
        NameText.text = text;
    }

    public void SetPhotoTo(Image photo)
    {
        Picture = photo;
    }
}
