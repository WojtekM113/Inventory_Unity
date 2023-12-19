        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dictionary", menuName = "ScriptableObjects/ItemdsDatabaseScriptableObject", order = 2)]
public class ItemsDataBase : ScriptableObject
{
    public Dictionary<string, Item> itemsDictionary = new Dictionary<string, Item>();
    public  Item woodSword;
    public  Item woodBlock;
    public  Item diamond;

    public void OnEnable()
    {
        itemsDictionary = new Dictionary<string, Item>()
        {
            {"WOOD_SWORD", woodSword},
            {"WOOD_BLOCK", woodBlock},
            {"DIAMOND", diamond}
        };
        
    }
   


    
}
 