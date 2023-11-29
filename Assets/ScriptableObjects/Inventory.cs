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
    
    public void CheckItems()
    {
        foreach (InventorySlot inventoryItem in inventorySlots)
        {    
            Debug.Log(inventoryItem.itemName);
            Debug.Log(inventoryItem.itemAmount);
        }   
    }

    public void AddItem(string itemKey, int itemAmount = 1, int slotIndex = -1)
    {
        if (slotIndex != -1)
        {
            //UWAGA jezeli item name jest taki sam to nadpisuje item
            //to dodajemy amount a nie zmieniamy.
            inventorySlots[slotIndex].itemName = itemKey;
            inventorySlots[slotIndex].itemAmount = itemAmount;
            return;
        }
        
        // znajdź pierwszy wolny slot albo pierwszy slot z takim samym itemKey. Jezeli slot ma taki sam itemKey to dodaj itemAmount do itemAmount w tym slocie
        // jezeli nie ma takiego slotu to dodaj nowy slot z tym itemKey i itemAmount

        for (int i = 0; i < inventorySlots.Count; i++)
        {
            if (inventorySlots[i].itemName == itemKey)
            {
                inventorySlots[i].itemAmount += itemAmount;
                return;
            }
        }
        
        //Ew jak mamy nieograniczone inventory, stworzy nowy slot i dodaj do listy
        /*InventorySlot inventorySlot = new InventorySlot{itemName = itemKey, itemAmount = itemAmount};
        inventorySlots.Add(inventorySlot);
        InventoryItems.Add(itemKey, inventorySlot);*/
        
        //Musisz przewidzieć że nadpisujesz item. Co się stanie z itemkiem który był w tym slocie poprzednio?
    }

    public void RemoveItem(string itemKey)
    {
        /*
         * Sprawdzamy czy mamy już ten item w naszym inventory.
         * Jeśli tak to zmniejszamy jego ilość o 1.
         * Jeśli nie to zwracamy komunikat o błędzie.
         */
        /*if (InventoryItems.TryGetValue(itemKey, out InventorySlot item))
        {
            item.itemAmount--;
            return;
        }

        Debug.LogError("Nie masz tego itemu w swoim inventory.");*/
    }
}

[Serializable]
public class InventorySlot
{
    public string itemName;
    public int itemAmount;
}
