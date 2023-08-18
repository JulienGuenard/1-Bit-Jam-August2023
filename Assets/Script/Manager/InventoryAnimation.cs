using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAnimation : MonoBehaviour
{
    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Show()
    {
        animator.SetBool("Show", true);
    }

    public void Hide()
    {
        animator.SetBool("Show", false);
    }
}
