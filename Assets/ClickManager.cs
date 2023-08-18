using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickManager : MonoBehaviour
{


    static public ClickManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void ClickItem(GameObject obj)
    {
        MixManager.instance.Mix(obj);
    }

    public void ClickElsewhere()
    {
        MixManager.instance.CancelMix();
    }
}
