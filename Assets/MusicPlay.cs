using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicPlay : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.PlayMusic(0);
    }

    void OnEnable()
    {
        if (AudioManager.instance == null) return;
        AudioManager.instance.PlayMusic(0);
    }
}
