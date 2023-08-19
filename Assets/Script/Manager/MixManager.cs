using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixManager : MonoBehaviour
{
    public bool isMixing;
    ItemBehaviour itemMixed;

    public List<Item> potionList = new List<Item>();

    static public MixManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void Mix(ItemBehaviour itemB)
    {
        Item item = itemB.GetComponent<ItemBehaviour>().item;

        if (!item.isIngredient) return;
        if (isMixing) { MixNew(itemB); return; }
        if (item == null) return;
        
        isMixing = true;
        itemMixed = itemB;

        TooltipManager.instance.ShowTooltipAction("Pick an other ingredient to make potion.");
    }

    void MixNew(ItemBehaviour itemB)
    {
        if (itemMixed == itemB) { CancelMix(); return; }

        Item item1 = itemB.item;
        Item item2 = itemMixed.item;
        Item itemCrafted = null;

        foreach (Item pot in potionList)
        {
            foreach (Recipe recipe in pot.allRecipeList)
            {
                if (item1.itemName == recipe.recipeList[0].itemName && item2.itemName == recipe.recipeList[1].itemName
                 || item1.itemName == recipe.recipeList[1].itemName && item2.itemName == recipe.recipeList[0].itemName)
                { itemCrafted = pot; break; }
            }
        }
        AudioManager.instance.PlaySound(2);
        InventoryManager.instance.LoseItem(itemB);
        InventoryManager.instance.LoseItem(itemMixed);
        InventoryManager.instance.GainItem(itemCrafted);
        CancelMix();
    }

    public void CancelMix()
    {
        isMixing = false;
        TooltipManager.instance.HideTooltipAction();
    }
}
