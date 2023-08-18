using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public List<Item> plantList;
    public List<Item> potionList;

    public float yOffset;
    public float xOffset;

    public TextMeshProUGUI tooltipText;

    bool isMakingPot = false;

    Item selectedItem;

    public void ShowTooltip(GameObject obj)
    {
        if (isMakingPot) return;
        Item item = CheckItem(obj);
        if (item != null) Show(item);
    }

    public void HideTooltip()
    {
        if (isMakingPot) return;
        gameObject.SetActive(false);
    }

    Item CheckItem(GameObject obj)
    {
        ItemBehaviour itemBehaviour = obj.GetComponent<ItemBehaviour>();

        if (itemBehaviour.item == null) return null;

        transform.localPosition = obj.transform.localPosition + new Vector3(xOffset, yOffset, 0);
        gameObject.SetActive(true);
        return itemBehaviour.item;
    }

    void Show(Item item)
    {
        tooltipText.text = "<size=38>" + item.itemName + "</size><br><size=28>" + item.itemDescription + "</size>";
    }
}
