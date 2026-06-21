using UnityEngine;
using UnityEngine.LowLevel;

public class WorkingState : State
{

    public Player player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }


    public override void Updating()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.popupManager.CloseAll();
        }
    }
}
