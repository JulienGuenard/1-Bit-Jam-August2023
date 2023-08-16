using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    public Item item;
    Image image;

    void Awake()
    {
        image = GetComponent<Image>();
        UpdateItem();
    }

    void Update()
    {
        UpdateItem();
    }

    void UpdateItem()
    {
        if (item == null)
        {
            image.sprite = null;
            image.color = Color.black;
            return;
        }
        image.color = Color.white;
        image.sprite = item.sprite;
    }
}
