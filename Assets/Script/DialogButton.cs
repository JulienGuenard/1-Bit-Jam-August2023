using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogButton : MonoBehaviour
{
    Animator animator;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        animator.SetBool("Hovered", true);
    }

    private void OnMouseExit()
    {
        animator.SetBool("Hovered", false);
    }
}
