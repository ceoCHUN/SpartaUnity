using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;



public enum ItemType
{
    Equipment,
    Consumales,
    Etc
}

[System.Serializable]
public class Item 
{
    //아이템 정보
    public ItemType itemType;
    public Sprite itemSprite;
    public string itemName;
    public string desc;

    public bool isWear;
    public int itemCount;

    public List<ItemEffect> efts;

    public bool Use()
    {
        bool isUsed = false;
        foreach (ItemEffect eft in efts) 
        {
            isUsed = eft.ExecuteRole();
        }
        return isUsed;
    }

}
