using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    
    [SerializeField] private UI_Inventory uiInventory;
    private Inventory inventory;
    private GameObject invBox;
    private void Awake(){
       
        inventory = new Inventory();
         
    }
    void Start()
    {
        invBox = GameObject.FindGameObjectWithTag("InventoryBox");
        uiInventory.SetInventory(inventory);
        invBox.SetActive(!invBox.activeSelf);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Inventory")){
            invBox.SetActive(!invBox.activeSelf);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld!=null){
           inventory.AddItem(itemWorld.GetItem());
           itemWorld.DestroySelf();
        }else{
            SceneManager.LoadScene("SecondScene");
        }
    }
    
}
