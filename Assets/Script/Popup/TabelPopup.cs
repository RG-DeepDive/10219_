using UnityEngine;
using UnityEngine.UI;

public class TabelPopup : PopupBase
{

    public Button closeButton;
    public Player player;

    private void Awake()
    {
        closeButton.onClick.AddListener(ClosePopup);
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
