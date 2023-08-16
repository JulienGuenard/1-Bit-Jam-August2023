using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogButton : MonoBehaviour
{
    Animator animator;

    public int choice;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnClick()
    {
       if (choice == 1) SceneManager.instance.NewScene(SceneName.Platformer);
       if (choice == 2) SceneManager.instance.NewScene(SceneName.Interlude);
       if (choice == 3) SceneManager.instance.NewScene(SceneName.Introduction);
    }
}
