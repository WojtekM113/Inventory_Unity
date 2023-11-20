using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ScriptableObject", menuName = "ScriptableObjects/InventoryItem", order = 1)]
public class InventoryItem : ScriptableObject
{
   public string itemID;
   public int quantinty;
}
