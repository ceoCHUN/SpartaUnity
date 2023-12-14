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
        slots = slotHolder.GetComponentsInChildren<Slot>(); //���ϴ� ������Ʈ �ѹ���
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
                Debug.Log("���������°�? Ȱ��"+ i);
            }
            else
            {
                slots[i].GetComponent<Button>().interactable = false;
                Debug.Log("���������°�? ��Ȱ��" + i);
            }
        }
    }
    public void AddSlot()
    {
        Debug.Log("�̰Ŵ���?");
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
