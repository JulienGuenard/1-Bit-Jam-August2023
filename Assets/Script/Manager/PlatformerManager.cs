using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerManager : MonoBehaviour
{
    public GameObject platformer1;
    public GameObject platformer2;
    public GameObject platformer3;

    GameObject platformerActual;

    static public PlatformerManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        platformerActual = platformer1;
    }

    public void PlatformerStart(int id)
    {
        if (id == 1) GeneratePlatformerNew(platformer1);
        if (id == 2) GeneratePlatformerNew(platformer2);
        if (id == 3) GeneratePlatformerNew(platformer3);
        SceneManager.instance.NewScene(SceneName.Platformer);
    }

    public void GeneratePlatformer()
    {
        GeneratePlatformerNew(platformerActual);
    }

    void GeneratePlatformerNew(GameObject platformer)
    {
        foreach (GameObject obj in SceneManager.instance.platformer) { Destroy(obj); }

        GameObject newObj = Instantiate(platformer);
        newObj.SetActive(false);
        SceneManager.instance.platformer.Clear();
        SceneManager.instance.platformer.Add(newObj);
    }
}
