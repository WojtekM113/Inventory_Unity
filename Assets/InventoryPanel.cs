using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InventoryPanel : MonoBehaviour
{
    public Inventory playerInventory;
    public static bool isInventoryActive;
    public GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            gameObject.SetActive(!gameObject.activeSelf);
            isInventoryActive = gameObject.activeSelf;
        }
    }
}
