using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject inventoryUi;
    private bool isInventoryUiActive = false;
    public Inventory Inventory;
    
    // // Start is called before the first frame update
    void Start()
    {
        Inventory.InventoryItems.Add("WOOD_SWORD", 5);
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

        transform.position += new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, verticalInput * movementSpeed * Time.deltaTime);

    }

 
    void ShowItems()
    {
       // SceneManager.LoadSceneAsync("Scenes/PlayerInventory"); 
        //gameobject set active    
        if (!isInventoryUiActive)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("PlayerInventory"));
            isInventoryUiActive = true;
            Inventory.CheckItems();
            
        }else 
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName("SampleScene"));
            isInventoryUiActive = false;
        }
    }

         

    
}






































