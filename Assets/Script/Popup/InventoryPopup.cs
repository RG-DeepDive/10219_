using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPopup : PopupBase
{
    public Button closePopup;
    public Player player;

    public RectTransform materialPanel;

    public InventoryManager inventoryManager;

    public Image[] chlidren;
    public TextMeshProUGUI text;

    private void Awake()
    {
        closePopup.onClick.AddListener(ClosePopup);
        chlidren = materialPanel.GetComponentsInChildren<Image>(true);
    }

    public override void OpenPopup()
    {
        UpdateItemInfo();
        base.OpenPopup();
        player.state = player.GetComponent<WorkingState>(); //움직임 불가
    }

    public override void ClosePopup()
    {
        base.ClosePopup();
        player.state = player.GetComponent<WalkingState>(); //움직임 가능
    }

    //InventoryManager의 inventory 정보 옯겨오기
    void UpdateItemInfo()
    {
        for (int  i = 0; i < inventoryManager.GetInventory().Length; i++)
        {
            text = chlidren[i+1].GetComponentInChildren<TextMeshProUGUI>(true);
            print(text.IsUnityNull());
            text.text = inventoryManager.GetInventory()[i].amount + "/99";

        }
    }

}
