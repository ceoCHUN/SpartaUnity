using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory_UI : MonoBehaviour
{
    Inventory inven;

    public Slot[] slots;
    public Transform slotHolder;

    private void Start()
    {
        inven = Inventory.Instance;
        slots = slotHolder.GetComponentsInChildren<Slot>(); //원하는 컴포넌트 한번에
        inven.onSlotCountChange += SlotChange;
        inven.onChangeItem += RedrawSlotUI;
        
    }

    void SlotChange(int val)
    {
        for(int i = 0; i < slots.Length; i++) 
        {
            slots[i].slotIndex = i;
            if(i < inven.SlotCount)
            {
                slots[i].GetComponent<Button>().interactable = true;
                Debug.Log("여기찍히는겨? 활성"+ i);
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;
                Debug.Log("여기찍히는겨? 비활성" + i);
            }
        }
    }
    public void AddSlot()
    {
        Debug.Log("이거눌림?");
        inven.SlotCount++;
    }

    void RedrawSlotUI()
    {
        for(int i = 0; i < slots.Length;i++)
        {
            slots[i].RemoveSlot();
        }
        for(int i = 0;i < inven.items.Count;i++)
        {
            slots[i].item = inven.items[i];
            slots[i].UpdateSlotUI();
        }
    }
}
