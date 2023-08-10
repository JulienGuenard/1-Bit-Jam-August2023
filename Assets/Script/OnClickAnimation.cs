using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickAnimation : MonoBehaviour
{
    [SerializeField] List<AudioClip> rdmAudioList;

    Animator animator;
    AudioSource audioS;

    private void Start()
    {
        animator = GetComponent<Animator>();
        audioS = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        Action();
    }

    void Action()
    {
        animator.SetTrigger("Click");
        audioS.PlayOneShot(rdmAudioList[Random.Range(0, 2)]);
    }
}
