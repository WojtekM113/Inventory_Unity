using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    int inventoryCap = 27;
    public ItemsDataBase itemsDataBase;
    List <InventoryItem> InventoryItems = new List<InventoryItem>();
    // // Start is called before the first frame update
    void Start()
    {
         InventoryItems.Add(itemsDataBase.itemsDictionary["WOOD_SWORD"]);
         InventoryItems.Add(itemsDataBase.itemsDictionary["WOOD_SWORD"]);
         InventoryItems.Add(itemsDataBase.itemsDictionary["WOOD_BLOCK"]);
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
            for (int i = 0; i < InventoryItems.Count; i++)
            {
                Debug.Log("-----------------");
                
                Debug.Log(InventoryItems[i]);
                Debug.Log(InventoryItems[i].quantinty);


                
            }
        }
    }
}
