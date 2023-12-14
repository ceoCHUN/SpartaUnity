using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerInfo_UI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI id;
    [SerializeField] TextMeshProUGUI job;
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] TextMeshProUGUI lv;
    [SerializeField] TextMeshProUGUI exp;
    [SerializeField] TextMeshProUGUI desc;
    [SerializeField] Slider exoSlider;

    public Knight knight;

    void Start()
    {
        knight = new Knight();
        ShowCharacterInfo();
    }

    public void ShowCharacterInfo()
    {
        id.text = knight.id.ToString();
        job.text = knight.job.ToString();
        name.text = knight.name.ToString();
        lv.text = knight.lv.ToString();
        exp.text = knight.exp.ToString();
        desc.text = knight.desc;
        exoSlider.value = knight.exp;
    }

}
