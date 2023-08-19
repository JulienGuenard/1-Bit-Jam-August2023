using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public Item plantLight;
    public Item plantNormal;
    public Item plantDark;
    public Item potLight;
    public Item potNormal;
    public Item potDark;
    public List<int> choiceList = new List<int>();
    public List<TextMeshProUGUI> choiceButtonList;

    static public DialogManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void NewChoices(List<Choice> choices)
    {
        choiceList.Clear();
        for (int i = 0; i < 2; i++)
        {
            choiceButtonList[i].text = choices[i].text;
            choiceList.Add(choices[i].outcome);
        }
    }

    public void OnClick(int choice)
    {
        int outcome = 1;
        if (choice == 1) outcome = choiceList[0];
        if (choice == 2) outcome = choiceList[1];
        if (choice == 3) outcome = 3;

        Debug.Log("choice: " + choice);
        Debug.Log("outcome: " + outcome);

        if (outcome == 1) PlatformerManager.instance.PlatformerStart(1);
        if (outcome == 2) SceneManager.instance.NewScene(SceneName.Interlude);
        if (outcome == 3) SceneManager.instance.NewScene(SceneName.Introduction);
        if (outcome == 4) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 5) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }

        // Mum
        if (outcome == 10) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 11)
        {
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            SceneManager.instance.NewScene(SceneName.Interlude);
        }
        if (outcome == 12) { CharacterManager.instance.ChangeAlignment(-1); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 13) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 14) { InventoryManager.instance.GainItem(plantLight); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 15) PlatformerManager.instance.PlatformerStart(3);

        // TwinBrother
        if (outcome == 20) { InventoryManager.instance.GainItem(potDark); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 21) SceneManager.instance.NewScene(SceneName.Interlude);
        if (outcome == 22) { InventoryManager.instance.GainItem(potNormal); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 23) SceneManager.instance.NewScene(SceneName.Interlude);
        if (outcome == 24) { InventoryManager.instance.GainItem(potLight); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 25) SceneManager.instance.NewScene(SceneName.Interlude);

        // SweetBrother
        if (outcome == 30)
        {
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            SceneManager.instance.NewScene(SceneName.Interlude);
        }
        if (outcome == 31) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 32) { InventoryManager.instance.GainItem(plantNormal); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 33) PlatformerManager.instance.PlatformerStart(1);
        if (outcome == 34)
        {
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantLight);
            SceneManager.instance.NewScene(SceneName.Interlude);
        }
        if (outcome == 35) PlatformerManager.instance.PlatformerStart(3);

        // Bard
        if (outcome == 40) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 41) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 42) { CharacterManager.instance.ChangeAlignment(1); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 43) { CharacterManager.instance.ChangeAlignment(-1); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 44)
        {
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantLight);
            SceneManager.instance.NewScene(SceneName.Interlude);
        }
        if (outcome == 45) { InventoryManager.instance.GainItem(potLight); SceneManager.instance.NewScene(SceneName.Interlude); }

        // Wizard
        if (outcome == 50) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 51) SceneManager.instance.NewScene(SceneName.Interlude);
        if (outcome == 52) PlatformerManager.instance.PlatformerStart(1);
        if (outcome == 53) PlatformerManager.instance.PlatformerStart(3);
        if (outcome == 54) 
        {
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantDark);
            InventoryManager.instance.GainItem(plantLight);
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantDark);
            InventoryManager.instance.GainItem(plantLight);
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantDark);
            InventoryManager.instance.GainItem(plantLight);
            InventoryManager.instance.GainItem(plantNormal);
            InventoryManager.instance.GainItem(plantDark);
            InventoryManager.instance.GainItem(plantLight);
            SceneManager.instance.NewScene(SceneName.Interlude); 
        }
        if (outcome == 55)
        {
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            SceneManager.instance.NewScene(SceneName.Interlude);
        }

        // Blizzard
        if (outcome == 60) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }
        if (outcome == 61) PlatformerManager.instance.PlatformerStart(2);

        // CoinFlip
        if (outcome == 70)
        {
            if (Random.Range(0, 2) == 0)   InventoryManager.instance.LoseItemLast();
            else                           InventoryManager.instance.GainItem(plantLight);
            SceneManager.instance.NewScene(SceneName.Interlude);
        }
        if (outcome == 71) SceneManager.instance.NewScene(SceneName.Interlude);

        // HerbFest
        if (outcome == 80) PlatformerManager.instance.PlatformerStart(1);
        if (outcome == 81) SceneManager.instance.NewScene(SceneName.Interlude);

        // LostInForest
        if (outcome == 90) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 91) { InventoryManager.instance.LoseItemLast(); SceneManager.instance.NewScene(SceneName.Interlude); }

        // SnakeInvasion
        if (outcome == 100) PlatformerManager.instance.PlatformerStart(2);
        if (outcome == 101)
        {
            InventoryManager.instance.LoseItemLast();
            InventoryManager.instance.LoseItemLast();
            SceneManager.instance.NewScene(SceneName.Interlude);
        }

        // Ending
        if (outcome == 110) PlatformerManager.instance.PlatformerStart(1);
        if (outcome == 111) SceneManager.instance.NewScene(SceneName.Interlude);
    }
}
