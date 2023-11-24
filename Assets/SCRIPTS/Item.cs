using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dictionary", menuName = "ScriptableObjects/Item", order = 3)]
public class Item : ScriptableObject

{
    public string itemName;
    public bool isStackable = false;
    public bool canBePlaced = false;
}
