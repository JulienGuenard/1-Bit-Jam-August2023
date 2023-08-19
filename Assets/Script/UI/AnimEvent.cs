using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvent : MonoBehaviour
{
    public void EndIntroduction()
    {
        AudioManager.instance.PlayMusic(1);
        SceneManager.instance.NewScene(SceneName.Interlude);
    }

    public void EndInterlude()
    {
        EventManager.instance.EventNew();
        SceneManager.instance.NewScene(SceneName.Dialog);
    }
}
