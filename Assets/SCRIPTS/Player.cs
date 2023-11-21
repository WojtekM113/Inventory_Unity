using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{ 
 
    public ItemsDataBase itemsDataBase;
    Dictionary<string, int> InventoryItems = new Dictionary<string, int>();
    // // Start is called before the first frame update
    void Start()
    {
         InventoryItems.Add("WOOD_SWORD", 5);
         InventoryItems.Add("WOOD_BLOCK", 1);
         
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
             ShowItems();
        }

        Movement();
         

    } 
    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        int movementSpeed = 10;

        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);

    }
    void ShowItems()
    {
        if (InventoryItems.Count == 0)
        {
            Debug.LogWarning("NO_ITEMS");
        }
        else
        {
            foreach (KeyValuePair<string,int> inventoryItem in InventoryItems)
            {
                Debug.Log(itemsDataBase.itemsDictionary[inventoryItem.Key]);
                Debug.Log(inventoryItem.Value);
            }
        }
    }
}
