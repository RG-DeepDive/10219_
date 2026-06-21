using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public Dictionary<Item, int> inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public Item FindItemByType(string type)
    {
        foreach (Item item in inventory.Keys)
        {
            if (item.type == type)
            {
                return item;
            }
        }
        return null;
    }

    public void PlusOrMinusItemAmountByType(string type, int amount)
    {
        Item target = FindItemByType(type);
        if (target != null)
        {
            inventory[target] += amount;
        }
    }
}
