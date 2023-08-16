using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerManager : MonoBehaviour
{
    public GameObject platformerObj;

    static public PlatformerManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void GenerateNewPlatformer()
    {            
        foreach (GameObject obj in SceneManager.instance.platformer) { Destroy(obj); }

        GameObject newObj = Instantiate(platformerObj);
        newObj.SetActive(false);
        SceneManager.instance.platformer.Clear();
        SceneManager.instance.platformer.Add(newObj);
    }
}
