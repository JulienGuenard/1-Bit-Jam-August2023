using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBehaviour : MonoBehaviour
{
    public Item item;
    public Sprite defaultSprite;
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
            image.sprite = defaultSprite;
            image.color = Color.black;
            image.raycastTarget = false;
            return;
        }
        image.raycastTarget = true;
        image.color = Color.white;
        image.sprite = item.sprite;
    }
}
