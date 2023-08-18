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
    public void LoseItem(GameObject obj)
    {
        ItemBehaviour itemB = obj.GetComponent<ItemBehaviour>();

        itemB.item = null;
        slotList.Remove(itemB);
        Transform origin = obj.transform.parent;
        obj.transform.SetParent(transform);
        obj.transform.SetParent(origin);
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
        if (itemCount == 5) return;

        slotList[itemCount].item = item;
        itemCount++;
    }
}
