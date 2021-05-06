using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public int iLevelToLoad;
    public string sLevelToLoad;
    public bool useInt = false;
    public Player playerObject;
    private GameObject player;
    private GameObject inventoryCanvas;
    private GameObject playerCamera;
    private Inventory inventory;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventoryCanvas = GameObject.FindGameObjectWithTag("InventoryCanvas");
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision){
        GameObject collisionGameObject = collision.gameObject;
        if(collisionGameObject.name=="Player"){
            LoadScene();
        } 

    }


    void LoadScene(){

        if(playerObject.inventory.GetItemList().Count==4){
            
            SceneManager.LoadScene(sLevelToLoad);

        }

    }
}
