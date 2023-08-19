using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource soundSource;

    public List<AudioClip> musicList;
    public List<AudioClip> soundList;

    static public AudioManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        musicSource.Stop();
    }

    public void PlayMusic(int music)
    {
        musicSource.Stop();
        musicSource.PlayOneShot(musicList[music]);
    }

    public void PlaySound(int sound)
    {
        soundSource.pitch = Random.Range(0.8f, 1.2f);
        soundSource.PlayOneShot(soundList[sound]);
    }
}
