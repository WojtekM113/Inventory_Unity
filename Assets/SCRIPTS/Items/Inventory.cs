using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[CreateAssetMenu(fileName = "Inventory", menuName = "ScriptableObjects/InventoryObject", order = 3)]
public class Inventory : ScriptableObject
{
    public ItemsDataBase itemsDataBase;

    public List<InventorySlot> inventorySlots = new List<InventorySlot>();
    //Dictionary tylko pomaga nam w szybkim dostępie do danych.
 

    // public void CheckItems()
    // {
    //     foreach (InventorySlot inventoryItem in inventorySlots)
    //     {
    //         //itemsDataBase.itemsDictionary[inventoryItem.itemName].itemName
    //         Debug.Log(inventoryItem.itemName);
    //         Debug.Log(inventoryItem.itemAmount);
    //
    //     }
    // }

    public void AddItem(string itemKey, int itemAmount = 1, int slotIndex = -1)
    {
        if (slotIndex != -1)
        {
            //UWAGA jezeli item name jest taki sam to nadpisuje item
            //to dodajemy amount a nie zmieniamy.

            /*inventorySlots[slotIndex].itemAmount = itemAmount;*/
            inventorySlots[slotIndex].itemIndex = slotIndex;
            inventorySlots[slotIndex].itemName = itemKey;

        }
        // znajdź pierwszy wolny slot albo pierwszy slot z takim samym itemKey.
        // Jezeli slot ma taki sam itemKey to dodaj itemAmount do itemAmount w tym slocie
        // jezeli nie ma takiego slotu to dodaj nowy slot z tym itemKey i itemAmount 
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            if (inventorySlots[i].itemName == itemKey)
            {
                inventorySlots[i].itemAmount += itemAmount;

                /*if (inventorySlots[i].itemAmount > 64 )
                {                        
                Szukamy pustego slota
                dodajemy do niego item
                I tak za każdym razem do czasu aż nie skończą nam sie sloty w ekwipunku
                }*/
            }
        }
        //Ew jak mamy nieograniczone inventory, stworzy nowy slot i dodaj do listy
        /*InventorySlot inventorySlot = new InventorySlot{itemName = itemKey, itemAmount = itemAmount};
        inventorySlots.Add(inventorySlot);
        InventoryItems.Add(itemKey, inventorySlot);*/
    }

    //Musisz przewidzieć że nadpisujesz item. Co się stanie z itemkiem który był w tym slocie poprzednio?


    
    public void RemoveItem(string itemKey, int i)
    {
        
        if (itemKey == inventorySlots[i].itemName)
        {
            inventorySlots[i].itemAmount--;
            return;
        }

        Debug.LogError("Nie masz tego itemu w swoim inventory.");
    }
    
    [Serializable]
    public class InventorySlot
    {
        public string itemName;
        public int itemAmount;
        public int itemIndex;
    }
}
