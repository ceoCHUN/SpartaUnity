using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IPointerUpHandler
{
    public int slotIndex;
    public Item item;

    // 표시정보
    public Image itemIcon;
    public Image isWear_Img;
    public TextMeshProUGUI itemCount;

    public void UpdateSlotUI()
    {
        itemIcon.sprite = item.itemSprite;
        itemIcon.gameObject.SetActive(true);
    }

    public void RemoveSlot()
    {
        item = null;
        itemIcon.gameObject.SetActive(false);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        bool isUse = item.Use();
        if (isUse)
        {
            Inventory.Instance.RemoveItem(slotIndex);
        }
    }
}
