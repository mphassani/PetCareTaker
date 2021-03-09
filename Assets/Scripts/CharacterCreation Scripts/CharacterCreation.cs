using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreation : MonoBehaviour
{
    private string petName;
    private string userName;

    public GameObject PetPrefab;
    public GameObject BackgroundPrefab; // Maybe could just be an image?

    // Potential Canvas groups, buttons, text, etc.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Will be the overall method that handles all of the functions relating to the player choosing their pet, giving it a name, ect.
    public void ChoosePet()
    {
        // Do pet choosing things
    }

    public void SetPetName(string petName)
    {
        this.petName = petName;
    }

    public void SetUserName(string userName)
    {
        this.userName = userName;
    }

    public string GetPetName()
    {
        return petName;
    }

    public string GetUserName()
    {
        return userName;
    }
}
