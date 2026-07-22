using UnityEngine;
using System;
using System.Collections.Generic;

public class ItemManager : MonoBehaviour
{
    public List<Item> items;

    public void PickedUpItem(Item item){
        items.Add(item);
    }
}
