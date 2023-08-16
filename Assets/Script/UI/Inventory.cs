using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<ItemBehaviour> slotList;

    List<Item> itemList = new List<Item>();
    Animator animator;
    public static Inventory instance;

    void Awake()
    {
        if (instance == null) instance = this;

        animator = GetComponent<Animator>();
    }

   public void LoseItem()
    {
        if (itemList.Count == 0) return;

        slotList[itemList.Count - 1].item = null;
        itemList.Remove(itemList[itemList.Count - 1]);
    }

    public void GainItem(Item item)
    {
        if (itemList.Count == 5) return;

        itemList.Add(item);
        slotList[itemList.Count-1].item = item;
    }

    public void Show()
    {
        animator.SetBool("Show", true);
    }

    public void Hide()
    {
        animator.SetBool("Show", false);
    }
}
