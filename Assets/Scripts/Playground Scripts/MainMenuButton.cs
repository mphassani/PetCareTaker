using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        if (toggle.isOn)
        {
            animator.SetTrigger("Pressed");
            animator.ResetTrigger("Presssed");
        }
        else
        {
            animator.SetTrigger("Normal");
            animator.ResetTrigger("Normal");
        }
    }
}
