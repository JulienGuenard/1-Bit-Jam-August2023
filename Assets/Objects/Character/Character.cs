using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Character", order = 1)]
public class Character : ScriptableObject
{
    public string characterName;

    public int alignment;

    public Sprite spriteDark;
    [TextArea] public string textDark;
    public List<Choice> choiceListDark;

    public Sprite spriteNormal;
    [TextArea] public string textNormal;
    public List<Choice> choiceListNormal;

    public Sprite spriteLight;
    [TextArea] public string textLight;
    public List<Choice> choiceListLight;


}