using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    
    private bool isInventoryUiActive = false;
    public Inventory Inventory;
    
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            Inventory.AddItem("WOOD_SWORD",2,1);     
        }
        
        if (Input.GetKeyDown(KeyCode.RightAlt))
        {
            Inventory.RemoveItem("WOOD_SWORD",1);
        }
        
        Movement();
    } 
    
    void Movement()
    {
        if(InventoryPanel.isInventoryActive) return;
        
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        int movementSpeed = 10;

        transform.position += new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);
    }
    
    
} 






































