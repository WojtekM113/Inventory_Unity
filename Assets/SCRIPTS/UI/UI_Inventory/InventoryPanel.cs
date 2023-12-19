using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public Inventory playerInventory;
     
    public static bool IsInventoryActive;
    
    [FormerlySerializedAs("gameObject")] 
    [SerializeField] private GameObject panelGameObject; 
    [FormerlySerializedAs("ItemContainer")] [SerializeField] private GameObject ItemIconContainer;
    [SerializeField] private GameObject ItemNameContainer;
    [SerializeField] private GameObject ItemAmountContainer;
    
    public ItemsDataBase itemsDataBase;
    
    
    void Update()
    {
        //if item = 0, delete?
        
        if(Input.GetKeyDown(KeyCode.Q))
        {
            panelGameObject.SetActive(!panelGameObject.activeSelf);
            IsInventoryActive = panelGameObject.activeSelf;

            if (IsInventoryActive)
            {
                for (int i = 0; i < playerInventory.inventorySlots.Count(); i++)
                {
                    ShowItemsInInventory(playerInventory.inventorySlots[i].itemName, playerInventory.inventorySlots[i].itemAmount);
                }
            }
            else
            {
                foreach (Transform child in panelGameObject.transform)
                {
                    Destroy(child.gameObject);
                }
            }
        }
    }

    void ShowItemsInInventory(string itemKey, int amount)
    {
        if (itemKey == null)
        {
            return;
        }

        if (itemsDataBase.itemsDictionary.TryGetValue(itemKey, out Item itemToShow))
        {
            
            Sprite itemIcon = itemToShow.itemIcon;
            string itemName = itemToShow.itemName;
            int itemAmount = amount;
            
            GameObject showItem = Instantiate(ItemIconContainer, panelGameObject.transform);
            showItem.GetComponent<Image>().sprite = itemIcon;

            GameObject showNameItem = Instantiate(ItemNameContainer, showItem.transform);
            showNameItem.GetComponent<TextMeshProUGUI>().text = itemName;

            GameObject showAmountItem = Instantiate(ItemAmountContainer, showNameItem.transform);
            showAmountItem.GetComponent<TextMeshProUGUI>().text = itemAmount.ToString();
        }
    }
}
