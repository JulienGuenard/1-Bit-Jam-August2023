using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EventManager : MonoBehaviour
{
    public List<Event> eventList;

    public Image portrait;
    public TextMeshProUGUI dialogText;

    public Event eventSelected;

    List<Event> eventListActual = new List<Event>();

    static public EventManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void EventNew()
    {
        if (eventListActual.Count == 0) ResetList();

        eventSelected = eventListActual[Random.Range(0, eventListActual.Count)];
        eventListActual.Remove(eventSelected);

        if (eventSelected.character == null)
        {
            portrait.sprite = eventSelected.sprite;
            dialogText.text = eventSelected.eventDescription;

            DialogManager.instance.NewChoices(eventSelected.choiceList);
            return;
        }

        CharacterManager.instance.characterSelected = eventSelected.character;

        if (eventSelected.character.alignment == 0)
        {
            portrait.sprite = eventSelected.character.spriteNormal;
            dialogText.text = eventSelected.character.textNormal;
            DialogManager.instance.NewChoices(eventSelected.character.choiceListNormal);
            return;
        }

        if (eventSelected.character.alignment == 1)
        {
            portrait.sprite = eventSelected.character.spriteLight;
            dialogText.text = eventSelected.character.textLight;
            DialogManager.instance.NewChoices(eventSelected.character.choiceListLight);
            return;
        }

        if (eventSelected.character.alignment == -1)
        {
            portrait.sprite = eventSelected.character.spriteDark;
            dialogText.text = eventSelected.character.textDark;
            DialogManager.instance.NewChoices(eventSelected.character.choiceListDark);
            return;
        }

    }

    void ResetList()
    {
        eventListActual.AddRange(eventList);
    }
}
