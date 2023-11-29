using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObjects/InventoryObject", order = 3)]
public class Inventory : ScriptableObject
{
    public ItemsDataBase itemsDataBase;
    public Dictionary<string, int> InventoryItems = new Dictionary<string, int>();
    
    public void CheckItems()
    {
        foreach (KeyValuePair<string,int> inventoryItem in InventoryItems)
        {    
            Debug.Log(itemsDataBase.itemsDictionary[inventoryItem.Key].itemName);
            Debug.Log(inventoryItem.Value);
        }   
    }   
}
