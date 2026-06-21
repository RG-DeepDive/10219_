 using UnityEngine;

[CreateAssetMenu]
public class Item : ScriptableObject
{
    private string item_name;
    private string item_type;
    private int amount_of_change;
    
    public string name => item_name;
    public string type => item_type;
    public int changing => amount_of_change;

}
