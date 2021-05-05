using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    private Toggle toggle;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnMouseDown() {
        if (!toggle.isOn) {
            animator.ResetTrigger("Pressed");
            animator.SetTrigger("Pressed");
        }
        else {
            animator.ResetTrigger("Normal");
            animator.SetTrigger("Normal");
        }
        toggle.isOn = !toggle.isOn;
    }

    public void ChangeSceneTo(int sceneNumber) {
        SceneManager.LoadScene(sceneNumber);
    }
}
