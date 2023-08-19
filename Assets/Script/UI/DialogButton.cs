using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogButton : MonoBehaviour
{
    public int choice;
    
    public void OnClick()
    {
       if (choice == 1) PlatformerManager.instance.PlatformerStart(1);
       if (choice == 2) SceneManager.instance.NewScene(SceneName.Interlude);
       if (choice == 3) SceneManager.instance.NewScene(SceneName.Introduction);
       if (choice == 4) PlatformerManager.instance.PlatformerStart(2);
       if (choice == 5) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }
    }
}
