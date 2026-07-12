using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InventoryManager: MonoBehaviour 
{

    public InventorySlot[] inventory;

    public Item item1;
    public Item item2;
    public Item item3;

    public InventorySlot material1;
    public InventorySlot material2;
    public InventorySlot material3;

    private void Start()
    {
        //인벤토리 -> view 연결 확인용
        inventory = new InventorySlot[3];
        item1 = new Item("material1", "material1");
        item2 = new Item("material2", "material2");
        item3 = new Item("material3", "material3");
        material1.SetAll(item1, 1);
        material2.SetAll(item2, 1);
        material3.SetAll(item3, 1);
        inventory[0] = (material1);
        inventory[1] = (material2);
        inventory[2] = (material3);
    }

    public int FindItemByType(string type)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            Item item = inventory[i].item;
            if (item.Type == type)
            {
                return i;
            }
        }
        return -1;
    }

    public void ChangingItemAmountByType (string type, int amount)
    {
        int target = FindItemByType(type);
        if (inventory[target] != null)
        {
            inventory[target].ChangeItemAmount(amount);
        }
    }

    public InventorySlot[] GetInventory()
    {
        return inventory;
    }
}
