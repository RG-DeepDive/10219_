using UnityEngine;


[System.Serializable]
public class InventorySlot
{
    public Item item;
    public int amount;
    public void SetItem(Item item)
    {
        this.item = item;
    }

    public void ChangeItemAmount(int amount)
    {
        this.amount += amount;
    }


    public void SetAll(Item item, int amount)
    {
        this.item = item;
        this.amount = amount;
    }
}
