using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvent : MonoBehaviour
{
    public void EndIntroduction()
    {
        SceneManager.instance.NewScene(SceneName.Interlude);
    }

    public void EndInterlude()
    {
        SceneManager.instance.NewScene(SceneName.Dialog);
    }
}
