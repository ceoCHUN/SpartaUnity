using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;

public class RightPanel_UI : MonoBehaviour
{
    public GameObject choicePanel;
    public GameObject status_Panel;
    public GameObject inventory_Panel;

    [SerializeField] 
    public void OnStatus()
    {
       status_Panel.SetActive(true);
       choicePanel.SetActive(false);
    }

    public void OnInventory()
    {
        inventory_Panel.SetActive(true);
        choicePanel.SetActive(false);
    }

    public void OnChoice()
    {
        choicePanel.SetActive(true);
    }

}
