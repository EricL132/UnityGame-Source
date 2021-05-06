using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    
    [SerializeField] private UI_Inventory uiInventory;
    

    public Inventory inventory;
    private GameObject invBox;
    private GameObject player;
    public GameObject inventoryCanvas;
    private GameObject playerCamera;
    private GameObject pauseMenu;
    
    private void Awake(){
       
       
        inventory = new Inventory();
        uiInventory.SetPlayer(this);
        uiInventory.SetInventory(inventory);
        pauseMenu = GameObject.Find("PauseCanvas");
    }

    void Start()
    {
        invBox = GameObject.FindGameObjectWithTag("InventoryBox");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        invBox.SetActive(!invBox.activeSelf);

        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(inventoryCanvas);
        DontDestroyOnLoad(playerCamera);
        DontDestroyOnLoad(pauseMenu);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetButtonDown("Inventory") && permaBool.insideInput==false){
            invBox.SetActive(!invBox.activeSelf);
        }
    }
    private void OnTriggerEnter2D(Collider2D collider){
        
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if (itemWorld!=null){
           inventory.AddItem(itemWorld.GetItem());
           itemWorld.DestroySelf();
        }
    }
    
}
