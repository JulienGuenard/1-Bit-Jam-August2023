using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public List<GameObject> titleScreen, introduction, interlude, dialog, platformer;

    List<List<GameObject>> all = new List<List<GameObject>>();

    static public SceneManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        all.Add(titleScreen); all.Add(introduction); all.Add(interlude); all.Add(dialog); all.Add(platformer);
    }

    void DisableAll()
    {
        foreach (List<GameObject> list in all) foreach (GameObject obj in list) obj.SetActive(false);
    }

    public void NewScene(SceneName scene)
    {
        DisableAll();
        if (scene == SceneName.Introduction)    foreach (GameObject obj in introduction)    obj.SetActive(true);
        if (scene == SceneName.Interlude)       foreach (GameObject obj in interlude)       obj.SetActive(true);
        if (scene == SceneName.Dialog)          foreach (GameObject obj in dialog)          obj.SetActive(true);
        if (scene == SceneName.Platformer)      foreach (GameObject obj in platformer)      obj.SetActive(true);
        if (scene == SceneName.Title)           foreach (GameObject obj in titleScreen)     obj.SetActive(true);

        if (scene == SceneName.Dialog) foreach (GameObject obj in dialog)   InventoryManager.instance.inventoryAnimation.Show();
        else                                                                InventoryManager.instance.inventoryAnimation.Hide();
    }
}
