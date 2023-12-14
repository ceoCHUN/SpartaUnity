using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class FieldItems : MonoBehaviour
{
    public Item item;
    public Image image;
    Inventory inven;

    public void SetItem(Item _item)
    {
        item.itemName = _item.itemName;
        item.itemSprite = _item.itemSprite;
        item.itemType = _item.itemType;
        item.desc = _item.desc;
        item.efts = _item.efts;

        image.sprite = item.itemSprite;
    }

    public Item GetItem() 
    { 
        return item; 
    }

    public void DestroyItem()
    {
        Destroy(gameObject);
    }

    public void OnClickGetItemButton()
    {
        if (inven.AddItem(GetItem()))
        {
            DestroyItem();
        }
    }
    

}
