using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

public class InventoryPanel : MonoBehaviour
{
    public Inventory playerInventory;
     
    public static bool isInventoryActive;
    [FormerlySerializedAs("gameObject")] 
    public GameObject panelGameObject;
    
    public ItemsDataBase itemsDataBase;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            panelGameObject.SetActive(!panelGameObject.activeSelf);
            isInventoryActive = panelGameObject.activeSelf;
            ShowItemsInInventory();
           
        }
    }

    void ShowItemsInInventory(string itemName)
    {
        foreach (Inventory.InventorySlot inventorySlot in playerInventory.inventorySlots)
        {
            itemName = itemsDataBase.itemsDictionary[inventorySlot.itemName].itemName;
            int itemAmount = inventorySlot.itemAmount;
            Sprite itemSprite = itemsDataBase.itemsDictionary[inventorySlot.itemName].itemIcon;
            //
        }
    }
}
