using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    [SerializeField] private GameObject modalBackground;

    private readonly Stack<PopupBase> popupStack = new Stack<PopupBase>();

    public bool HasPopup => popupStack.Count > 0;

    private void Awake()
    {
        if (modalBackground != null)
        {
            modalBackground.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseTopPopup();
        }
    }

    public void OpenPopup(PopupBase popup)
    {
        if (popup == null)
        {
            return;
        }

        popup.OpenPopup();
        popupStack.Push(popup);

        RefreshModalBackground();
    }

    public void CloseTopPopup()
    {
        if (popupStack.Count == 0)
        {
            return;
        }

        PopupBase topPopup = popupStack.Pop();
        topPopup.OnBack();

        RefreshModalBackground();
    }

    public void CloseAll()
    {
        while (popupStack.Count > 0)
        {
            PopupBase popup = popupStack.Pop();
            popup.ClosePopup();
        }

        RefreshModalBackground();
    }

    private void RefreshModalBackground()
    {
        if (modalBackground == null)
        {
            return;
        }

        modalBackground.SetActive(popupStack.Count > 0);
    }
}