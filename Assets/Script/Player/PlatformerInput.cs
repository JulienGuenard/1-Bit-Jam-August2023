using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlatformerInput : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public float fallForce;

    Rigidbody2D rigid;
    bool hasJumped = false;

    Animator animator;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        rigid.velocity = (speed * transform.right) + new Vector3(0, rigid.velocity.y, 0);

        if (!hasJumped && Input.GetKeyDown(KeyCode.Mouse0))
        {
            hasJumped = true;
            AudioManager.instance.PlaySound(1);
            animator.SetBool("Jump", true);
            rigid.AddForce(transform.up * jumpForce);
        }

        if (rigid.velocity.y < 0) rigid.velocity -= new Vector2(0, fallForce);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            if (transform.localRotation.y == 0) transform.localRotation = Quaternion.Euler(0, 180, 0);
            else transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (collision.tag == "Plant")
        {
            InventoryManager.instance.GainItem(collision.GetComponent<PlantBehaviour>().item);
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Exit")
        {
            SceneManager.instance.NewScene(SceneName.Interlude);
            PlatformerManager.instance.GeneratePlatformer();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            animator.SetBool("Jump", false);
            hasJumped = false;
        }
    }

        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            hasJumped = true;
        }
    }
}
