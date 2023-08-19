using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Choice
{
    public string text;
    public int outcome;
}

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Event", order = 1)]
public class Event : ScriptableObject
{
    public string eventName;
    public Character character;
    [TextArea] public string eventDescription;
    public Sprite sprite;
    public List<Choice> choiceList;
}