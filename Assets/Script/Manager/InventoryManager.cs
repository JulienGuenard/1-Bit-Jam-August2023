using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<ItemBehaviour> slotList;
    public InventoryAnimation inventoryAnimation;

    public bool isMixing;

    public int itemCount = 0;

    public static InventoryManager instance;

    void Awake()
    {
        if (instance == null) instance = this;

        foreach(ItemBehaviour i in slotList)
        {
            if (i.item != null) itemCount++;
        }
    }
    public void LoseItem(ItemBehaviour itemB)
    {
        itemB.item = null;
        slotList.Remove(itemB);
        Transform origin = itemB.transform.parent;
        itemB.transform.SetParent(transform);
        itemB.transform.SetParent(origin);
        slotList.Add(itemB);
        itemCount--;
    }

    public void LoseItemLast()
    {
        if (itemCount == 0) return;

        slotList[itemCount - 1].item = null;
        itemCount--;
    }
    public void GainItem(Item item)
    {
        if (itemCount == 10) return;

        slotList[itemCount].item = item;
        itemCount++;
    }
}
