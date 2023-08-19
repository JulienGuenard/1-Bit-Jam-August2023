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

    public void ClickItem(ItemBehaviour itemB)
    {
        AudioManager.instance.PlaySound(3);
        if (itemB.item.isIngredient)    { MixManager.instance.Mix(itemB);      return; }
        if (!itemB.item.isIngredient)   { DrinkManager.instance.Drink(itemB);  return; }
    }

    public void ClickElsewhere()
    {
        MixManager.instance.CancelMix();
        DrinkManager.instance.CancelDrink();
    }
}
