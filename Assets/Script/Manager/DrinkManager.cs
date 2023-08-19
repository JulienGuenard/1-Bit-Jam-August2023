using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    public bool isDrinking;
    public GameObject drinkPanel;

    public Item potLight;
    public Item potDark;

    ItemBehaviour itemDrinked;

    static public DrinkManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        drinkPanel.SetActive(false);
    }

    public void Drink(ItemBehaviour itemB)
    {
        Item item = itemB.GetComponent<ItemBehaviour>().item;

        if (isDrinking) return;
        if (item.isIngredient) return;
        if (item == null) return;

        isDrinking = true;
        drinkPanel.SetActive(true);
        itemDrinked = itemB;

        TooltipManager.instance.ShowTooltipAction("Who must drink ?");
    }

    public void CancelDrink()
    {
        drinkPanel.SetActive(false);
        isDrinking = false;
        TooltipManager.instance.HideTooltipAction();
    }

    public void DrinkPNJ()
    {
        if (itemDrinked.item == potLight) CharacterManager.instance.ChangeAlignment(1);
        if (itemDrinked.item == potDark) CharacterManager.instance.ChangeAlignment(-1);
        InventoryManager.instance.LoseItem(itemDrinked);
        CancelDrink();
    }

    public void DrinkYourself()
    {
        InventoryManager.instance.LoseItem(itemDrinked);
        CancelDrink();
    }
}
