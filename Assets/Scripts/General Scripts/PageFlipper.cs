using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageFlipper : MonoBehaviour
{
    public CanvasGroup PreviousButtonCanvasGroup;
    public CanvasGroup NextButtonCanvasGroup;
    public List<CanvasGroup> PageCanvasGroups;

    protected int totalPages;
    protected int currentPage;

    // Start is called before the first frame update
    void Start()
    {
        totalPages = PageCanvasGroups.Count;
        currentPage = 1;

        UpdatePages();
        UpdateButtons();
    }

    public void OnBackButtonClick()
    {
        currentPage = 1;

        UpdatePages();
        UpdateButtons();
    }

    public void OnPreviousButtonClick()
    {
        currentPage = currentPage - 1;
        if (currentPage < 1)
        {
            currentPage = 1;
        }

        UpdatePages();
        UpdateButtons();
    }

    public void OnNextButtonClick()
    {
        currentPage = currentPage + 1;
        if (currentPage > totalPages)
        {
            currentPage = totalPages;
        }

        UpdatePages();
        UpdateButtons();
    }

    public virtual void UpdatePages()
    {
        foreach (CanvasGroup canvasGroup in PageCanvasGroups)
        {
            Hide(canvasGroup);
        }

        Show(PageCanvasGroups[currentPage - 1]);
    }

    public void UpdateButtons()
    {
        Show(PreviousButtonCanvasGroup);
        Show(NextButtonCanvasGroup);

        if (currentPage == 1)
        {
            Hide(PreviousButtonCanvasGroup);
        }

        if (currentPage == totalPages)
        {
            Hide(NextButtonCanvasGroup);
        }
    }

    protected void Show(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        canvasGroup.blocksRaycasts = true;
    }

    protected void Hide(CanvasGroup canvasGroup)
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        canvasGroup.blocksRaycasts = false;
    }
}
