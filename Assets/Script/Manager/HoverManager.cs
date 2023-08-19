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
    public void HoverItem(ItemBehaviour itemB)
    {
        if (!canHover) return;
        if (itemB.item == null) return;

        Item item = itemB.item;

        string message = item.itemName + "<br>" + item.itemDescription;
        Transform trans = itemB.transform;

        TooltipManager.instance.ShowTooltipItemAtPos(message, trans);
    }
    public void UnhoverItem()
    {
        if (!canHover) return;
        TooltipManager.instance.HideTooltipItem();
    }
}
