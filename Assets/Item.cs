using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item {
    public enum ItemType{
        Paper,
        Sword
    }

    public ItemType itemType;
    public int amount;
    public string itemText;
    public Sprite GetSprite(){
        switch(itemType){
            default:
            case ItemType.Paper: return ItemAssets.Instance.paperSprite;
            case ItemType.Sword: return ItemAssets.Instance.swordSprite;
        }
    }
}
