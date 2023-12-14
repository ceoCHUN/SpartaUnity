using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;

    public delegate void OnChangeItem();
    public OnChangeItem onChangeItem;

    //획득한 아이템을 담을 리스트
    public List<Item> items = new List<Item>();

    private int slotCount;
    public int SlotCount
    {
        get => slotCount; 
        set 
        { 
            slotCount = value;
            onSlotCountChange.Invoke(slotCount);
        }
    }
    #region Singleton
    public static Inventory Instance;
    private void Awake()
    {
        if (Instance == null) 
        {
            Debug.Log("싱글토온~");
            Instance = this;
        }
        else if (Instance != this) 
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }
    #endregion
    private void Start()
    {        
        slotCount = 6;
        onSlotCountChange.Invoke(slotCount);
        Debug.Log("스따뜌~~ slotcount :" + slotCount);
    }

    public bool AddItem(Item _item)
    {
        if(items.Count < SlotCount)
        {
            items.Add(_item);
            if(onChangeItem != null)
            onChangeItem.Invoke();
            return true;
        }
        return false; 
        
    }

    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("COLLISION");
        if(collision.CompareTag("FieldItem"))
        {
            FieldItems fieldItems = collision.GetComponent<FieldItems>();
            if (AddItem(fieldItems.GetItem()))
            {
                fieldItems.DestroyItem();
            }
        }
    }
   */

    public void RemoveItem(int _index)
    {
        items.RemoveAt(_index);
        onChangeItem.Invoke();
    }

    public void OnFieldItemClick(FieldItems fieldItems)
    {
        if(AddItem(fieldItems.GetItem()))
        {
            fieldItems.DestroyItem();
        }
    }



}
