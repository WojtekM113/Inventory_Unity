using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dictionary", menuName = "ScriptableObjects/ItemdsDatabaseScriptableObject", order = 2)]
public class ItemsDataBase : ScriptableObject
{
    public Dictionary<string, InventoryItem> itemsDictionary = new Dictionary<string, InventoryItem>();
    public InventoryItem woodSword;
    public InventoryItem woodBlock;
    public InventoryItem diamond;

    public void OnEnable()
    {
        itemsDictionary = new Dictionary<string, InventoryItem>()
        {
            {"WOOD_SWORD", woodSword},
            {"WOOD_BLOCK", woodBlock},
            {"DIAMOND", diamond}
     
        };
    }
   


     
   
}
 