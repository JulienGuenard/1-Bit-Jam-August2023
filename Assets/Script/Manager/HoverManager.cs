using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverManager : MonoBehaviour
{
    public float tooltipOffsetX;
    public float tooltipOffsetY;

    public bool canHover;

    public static HoverManager instance;

    void Awake()
    {
        if (instance == null) instance = this;
    }
    public void HoverItem(GameObject obj)
    {
        if (!canHover) return;

        ItemBehaviour itemBehaviour = obj.GetComponent<ItemBehaviour>();

        if (itemBehaviour.item == null) return;

        Item item = itemBehaviour.item;

        string message = "<size=38>" + item.itemName + "</size><br><size=28>" + item.itemDescription + "</size>";
        Transform trans = obj.transform;

        TooltipManager.instance.ShowTooltipAtPos(message, trans);
    }
    public void UnhoverItem()
    {
        if (!canHover) return;
        TooltipManager.instance.HideTooltip();
    }
}
