using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public float yOffset;
    public float xOffset;

    public TextMeshProUGUI tooltipText;

    public void ShowTooltip(GameObject obj)
    {
        ItemBehaviour itemBehaviour = obj.GetComponent<ItemBehaviour>();

        if (itemBehaviour.item == null) return;

        Item item = itemBehaviour.item;

        tooltipText.text = "<size=38>" + item.itemName + "</size><br><size=28>" + item.itemDescription + "</size>";

        transform.localPosition = obj.transform.localPosition + new Vector3(xOffset, yOffset, 0);
        gameObject.SetActive(true);
    }

    public void HideTooltip()
    {
        gameObject.SetActive(false);
    }
}
