using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Status_UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI atk;
    [SerializeField] TextMeshProUGUI def;
    [SerializeField] TextMeshProUGUI hp;
    [SerializeField] TextMeshProUGUI ctk;

    public Knight knight;

    void Start()
    {
        ShowStatInfo();
    }

    public void ShowStatInfo()
    {
        atk.text = Knight.Instance.atk.ToString();
        def.text = Knight.Instance.def.ToString();
        hp.text = Knight.Instance.hp.ToString();
        ctk.text = Knight.Instance.ctk.ToString();
    }
}
