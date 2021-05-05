using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterCreation : MonoBehaviour
{
    // For testing
    public Text PetSelected;

    public Text PetName;
    public Text UserName;
    public Text PetType;

    public Text PetNameInputted;
    public Text UserNameInputted;

    // For testing
    public Text BackgroundSelected;

    private string petName;
    private string userName;

    public GameObject PetPrefab;
    public GameObject BackgroundPrefab; // Maybe could just be an image?

    // Potential Canvas groups, buttons, text, etc.
    public List<CanvasGroup> PageCanvasGroups;
    private int totalPages;
    private int currentPage;

    public List<Sprite> PetPictures;
    public Image ChosenPet;

    // Start is called before the first frame update
    void Start()
    {
        totalPages = PageCanvasGroups.Count;
        currentPage = 1;

        UpdatePages();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInputtedTextFields();
    }

    // Will be the overall method that handles all of the functions relating to the player choosing their pet, giving it a name, ect.
    public void ChoosePet()
    {
        // Do pet choosing things
    }

    public void SetPetName()
    {
        petName = PetName.text;
        PlayerPrefs.SetString("petName", petName);
    }

    public void SetUserName()
    {
        userName = UserName.text;
        PlayerPrefs.SetString("userName", userName);
    }

    public string GetPetName()
    {
        return petName;
    }

    public string GetUserName()
    {
        return userName;
    }

    public void OnPet1Press()
    {
        PetSelected.text = "Pet Selected: Cat";
        PetType.text = "Cat";
        PlayerPrefs.SetInt("petPrefab", 1);
        ChosenPet.sprite = PetPictures[0];
    }

    public void OnPet2Press()
    {
        PetSelected.text = "Pet Selected: Dog";
        PetType.text = "Dog";
        PlayerPrefs.SetInt("petPrefab", 2);
        ChosenPet.sprite = PetPictures[1];
    }

    public void OnPet3Press()
    {
        PetSelected.text = "Pet Selected: Bunny";
        PetType.text = "Bunny";
        PlayerPrefs.SetInt("petPrefab", 3);
        ChosenPet.sprite = PetPictures[2];
    }

    public void OnBackground1Press()
    {
        BackgroundSelected.text = "Pet Background Selected: Background1";
        PlayerPrefs.SetInt("backgroundPrefab", 1);
    }

    public void OnBackground2Press()
    {
        BackgroundSelected.text = "Pet Background Selected: Background2";
        PlayerPrefs.SetInt("backgroundPrefab", 2);
    }

    public void OnBackground3Press()
    {
        BackgroundSelected.text = "Pet Background Selected: Background3";
        PlayerPrefs.SetInt("backgroundPrefab", 3);
    }

    // For testing PlayerPrefs
    public void OnLastContinuePress()
    {
        SceneManager.LoadScene(1);
    }

    // For testing
    private void UpdateInputtedTextFields()
    {
        SetPetName();
        SetUserName();
        PetNameInputted.text = "Your pet's name: " + GetPetName();
        UserNameInputted.text = "Your username: " + GetUserName();
    }

    public void OnContinuePress()
    {
        currentPage++;
        if (currentPage > totalPages)
        {
            currentPage = totalPages;
        }

        UpdatePages();
    }

    private void UpdatePages()
    {
        foreach (CanvasGroup canvasGroup in PageCanvasGroups)
        {
            Hide(canvasGroup);
        }

        Show(PageCanvasGroups[currentPage - 1]);
    }

    private void Show(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.blocksRaycasts = true;
        canvasGroup.interactable = true;
    }

    private void Hide(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.blocksRaycasts = false;
        canvasGroup.interactable = false;
    }
}
