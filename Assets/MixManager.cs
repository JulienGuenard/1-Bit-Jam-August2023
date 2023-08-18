using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MixManager : MonoBehaviour
{
    public bool isMixing;
    GameObject itemMixed;

    public Item potion;

    static public MixManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }

    public void Mix(GameObject obj)
    {
        Item item = obj.GetComponent<ItemBehaviour>().item;

        if (isMixing) { MixNew(obj); return; }
        if (item == null) return;
        if (!item.isIngredient) return;

        isMixing = true;
        itemMixed = obj;
        HoverManager.instance.canHover = false;

        string message = "<size=38>" + "Make a Potion" + "</size><br><size=28>" + "Mix another ingredient." + "</size>";

        TooltipManager.instance.ShowTooltip(message);
    }

    void MixNew(GameObject obj)
    {
        if (itemMixed == obj) { CancelMix(); return; }
        InventoryManager.instance.LoseItem(obj);
        InventoryManager.instance.LoseItem(itemMixed);
        InventoryManager.instance.GainItem(potion);
        CancelMix();
    }

    public void CancelMix()
    {
        isMixing = false;
        HoverManager.instance.canHover = true;
        HoverManager.instance.UnhoverItem();
    }
}
