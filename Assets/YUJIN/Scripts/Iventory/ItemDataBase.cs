using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class ItemDataBase : MonoBehaviour
{
    public Canvas parentCanvas;
    public static ItemDataBase Instance;
    private void Awake()
    {
        Instance = this;
    }

    public List<Item> itemDB = new List<Item>();

    public GameObject fieldItemPrefab;
    public RectTransform[] pos;


    private void Start()
    {   
        for (int i = 0; i < 5; i++) 
        {
            
            GameObject go = Instantiate(fieldItemPrefab, pos[i]);
            go.transform.SetParent(parentCanvas.transform);
            go.GetComponent<FieldItems>().SetItem(itemDB[Random.Range(0,3)]);
            
            // 어디서부터 잘못된건지..^^
            Button btn = go.GetComponent<Button>();
            FieldItems fieldItems = go.GetComponent<FieldItems>();

            // 클릭 리스너 추가
            //btn.onClick.AddListener(delegate { inven.OnFieldItemClick(fieldItems); });
            Debug.Log("Inventory: " + (Inventory.Instance != null));
            Debug.Log("FieldItems: " + (fieldItems != null));

            btn.onClick.AddListener(delegate {
                if (Inventory.Instance != null && fieldItems != null)
                {
                    Inventory.Instance.OnFieldItemClick(fieldItems);
                }
                else
                {
                    Debug.LogError("Inventory or FieldItems is null");
                }
            });


        }
        
    }


}
