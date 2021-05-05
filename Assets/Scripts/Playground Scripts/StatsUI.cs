using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsUI : MonoBehaviour
{
    private Pet pet;

    public Camera mainCamera;

    public Text NameText;
    public StatsUIComponent HealthUI;
    public StatsUIComponent HappinessUI;
    public StatsUIComponent HungerUI;
    public Image Picture;

    public List<Sprite> PetPictures;

    // Start is called before the first frame update
    void Start()
    {
        HungerUI.SetValueTo(11);
        
        //Create functions for playerprefs
        NameText.text = PlayerPrefs.GetString("petName");

        if (PlayerPrefs.GetInt("petPrefab") == 1)
        {
            Picture.sprite = PetPictures[0];
        }
        else if (PlayerPrefs.GetInt("petPrefab") == 2)
        {
            Picture.sprite = PetPictures[1];
        }
        else if (PlayerPrefs.GetInt("petPrefab") == 3)
        {
            Picture.sprite = PetPictures[2];
        }

        pet = GameObject.FindGameObjectWithTag("Pet").GetComponent<Pet>();
        //HungerUI.SetValueTo(pet.GetHunger());
        //HappinessUI.SetValueTo(pet.GetHappiness());
        //HealthUI.SetValueTo(pet.GetCleansliness());
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
