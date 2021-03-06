using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ItemWorld : MonoBehaviour
{

    public static ItemWorld SpawnItemWorld(Vector3 position,Item item){
        Transform transform = Instantiate(ItemAssets.Instance.pfItemWorld, position, Quaternion.identity);
        ItemWorld itemWorld = transform.GetComponent<ItemWorld>();

        itemWorld.SetItem(item);
        return itemWorld;
    }
    
    private Item item;
    private SpriteRenderer spriteRenderer;
    private TextMeshPro textMeshPro;
    public void Awake(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        textMeshPro = transform.Find("text").GetComponent<TextMeshPro>();
    }
    public void SetItem(Item item){
        this.item = item;
        spriteRenderer.sprite = item.GetSprite();
        textMeshPro.SetText(item.itemText.ToString());
    }

    public Item GetItem(){
        return item;
    }

    public void DestroySelf(){
        Destroy(gameObject);
    }

     public static ItemWorld DropItem(Vector3 dropPos , Item item){
        ItemWorld nitem= SpawnItemWorld(dropPos,item);
        return  nitem;
    } 
}
