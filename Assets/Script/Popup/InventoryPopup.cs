using UnityEngine;
using UnityEngine.UI;

public class InventoryPopup : PopupBase
{
    public Button closePopup;
    public Player player;

    private void Awake()
    {
        closePopup.onClick.AddListener(ClosePopup);
    }

    public override void OpenPopup()
    {
        base.OpenPopup();
        player.state = player.GetComponent<WorkingState>();
    }

    public override void ClosePopup()
    {
        base.ClosePopup();
        player.state = player.GetComponent<WalkingState>();
    }
}
