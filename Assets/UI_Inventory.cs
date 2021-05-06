using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    private Transform itemSlotContainer;
    private Transform itemSlotTemplate;
        private Player player;

    public void SetPlayer(Player player){
        this.player = player;
    }

    public void Awake(){
        itemSlotContainer = transform.Find("itemSlotContainer");
        itemSlotTemplate = itemSlotContainer.Find("itemSlotTemplate");
    }
    public void SetInventory(Inventory inventory){
        this.inventory = inventory;
        inventory.OnItemListChanged += Inventory_OnItemListChanged;
        RefreshInventoryItems();
    }

    private void Inventory_OnItemListChanged(object sender, System.EventArgs e){
        RefreshInventoryItems();
    }

    private void RefreshInventoryItems(){
        foreach(Transform child in itemSlotContainer){
            if(child == itemSlotTemplate) continue;
            Destroy(child.gameObject);
        }
        int x = 0;
        int y = 0;
        float itemSlotCellSize = 50f;
        foreach(Item item in inventory.GetItemList()){
           RectTransform itemSlotRectTransform = Instantiate(itemSlotTemplate,itemSlotContainer).GetComponent<RectTransform>();
           itemSlotRectTransform.gameObject.SetActive(true);
/*             itemSlotRectTransform.GetComponent<Button>().onClick.AddListener(()=>{
                inventory.RemoveItem(item);
                //ItemWorld.DropItem(player.GetPosition(),item)
            }); */
           itemSlotRectTransform.anchoredPosition = new Vector2(x * itemSlotCellSize, y* itemSlotCellSize);
           Image image = itemSlotRectTransform.Find("item").GetComponent<Image>();
           image.sprite = item.GetSprite();  
           Text uiText = itemSlotRectTransform.Find("text").GetComponent<Text>();
           uiText.text = item.itemText.ToString();
           x++;
           if(x>=1){
               x=0;
               y--;
           }
        }
    }
}
