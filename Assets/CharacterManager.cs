using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public Character characterSelected;

    public List<Character> characterList;

    static public CharacterManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        foreach (Character character in characterList)
        {
            character.alignment = 0;
        }
    }

    public void ChangeAlignment(int value)
    {
        characterSelected.alignment += value;
        if (characterSelected.alignment > 1)    characterSelected.alignment = 1;
        if (characterSelected.alignment < -1)   characterSelected.alignment = -1;
        EventManager.instance.eventList.Add(EventManager.instance.eventSelected);
    }
}
