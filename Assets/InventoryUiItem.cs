using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUiItem : MonoBehaviour
{
    [SerializeField] private Image itemImage;

    [SerializeField] private TextMeshProUGUI itemName;

    [SerializeField] private TextMeshProUGUI itemAmount;

    public void SetItem(Sprite sprite, string itemName, string amount)
    {
        this.itemName.text = itemName;
        itemImage.sprite = sprite;
        itemAmount.text = amount;
    }
}
