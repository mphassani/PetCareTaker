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
        // pet = GameObject.FindGameObjectWithTag("Pet").GetComponent<Pet>();

        //Create functions for playerprefs
        NameText.text = PlayerPrefs.GetString("petName");

        if (PlayerPrefs.GetInt("backgroundPrefab") == 1)
        {
            mainCamera.backgroundColor = Color.red;
            Picture.sprite = PetPictures[0];
        }
        else if (PlayerPrefs.GetInt("backgroundPrefab") == 2)
        {
            mainCamera.backgroundColor = Color.green;
            Picture.sprite = PetPictures[1];
        }
        else if (PlayerPrefs.GetInt("backgroundPrefab") == 3)
        {
            mainCamera.backgroundColor = Color.blue;
            Picture.sprite = PetPictures[2];
        }
        else
        {
            mainCamera.backgroundColor = Color.cyan;
        }
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
