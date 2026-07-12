 using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    private string item_name;
    private string item_type;
    private int amount_of_change;
    
    public string Name => item_name;
    public string Type => item_type;
    public int Changing => amount_of_change;

    public Item(string item_name, string item_type)
    {
        this.item_name = item_name;
        this.item_type = item_type;
    }

}
