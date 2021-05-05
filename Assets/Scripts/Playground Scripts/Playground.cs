using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playground : MonoBehaviour
{
    public Pet Pet;
    public GameObject LeftBound;
    public GameObject RightBound;
    public GameObject BottomBound;
    public GameObject TopBound;

    public GameObject CatPrefab;
    public GameObject DogPrefab;
    public GameObject BunnyPrefab;

    void Start()
    {
        CreatePet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreatePet()
    {
        if (PlayerPrefs.GetInt("petPrefab") == 1)
        {
            Instantiate(CatPrefab);
        }
        else if (PlayerPrefs.GetInt("petPrefab") == 2)
        {
            Instantiate(DogPrefab);
        }
        else if (PlayerPrefs.GetInt("petPrefab") == 3)
        {
            Instantiate(BunnyPrefab);
        }
    }
}
