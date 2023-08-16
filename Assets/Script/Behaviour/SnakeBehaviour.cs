using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeBehaviour : MonoBehaviour
{
    Animator animator;

    public BoxCollider2D detectCol;
    bool isDetected = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (!isDetected)
            {
                detectCol.enabled = false;
                isDetected = true;
                animator.SetBool("GoUp", true);
            }else
            {
                Inventory.instance.LoseItem();
                Destroy(this.gameObject);
            }
            
        }
    }
}
