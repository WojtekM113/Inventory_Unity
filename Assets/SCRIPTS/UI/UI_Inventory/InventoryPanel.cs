using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    public GameObject panelGameObject;

    public GameObject ItemContainer;
    
    public ItemsDataBase itemsDataBase;
    
    
    void Update()
    {
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
         
            Debug.Log(itemAmount);
            
               
            GameObject showItem = Instantiate(ItemContainer, panelGameObject.transform);
            showItem.GetComponent<Image>().sprite = itemIcon;
        }
       
        
        
       

    }
}
