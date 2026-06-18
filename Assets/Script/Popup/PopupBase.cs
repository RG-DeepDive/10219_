using UnityEngine;

public class PopupBase : MonoBehaviour
{

    public virtual void OpenPopup()
    {
        gameObject.SetActive(true);
    }

    public virtual void ClosePopup()
    {
        gameObject.SetActive(false);
    }

    public virtual void OnBack()
    {
        ClosePopup();
    }
}
