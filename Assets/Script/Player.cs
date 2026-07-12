using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector3 direction;
    public Vector3 position;
    private float _rotate;
    public float rotate { get; set; }
    public float speed = 5;
    public Transform trans;
    public State state;
    private Rigidbody2D rb;
    public bool isTabel;

    public PopupBase tabelPopup;
    public PopupBase invenPopup;
    public PopupManager popupManager;

    public InventoryManager invenManager;

    public int level;



    void Start()
    {
        trans = transform;
        position = trans.position;
        rotate = 0;
        state = gameObject.GetComponent<WalkingState>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        popupManager = gameObject.GetComponent<PopupManager>();
    }

    void Update()
    {
        state.Updating();  //플레이어 상태에 따른 업데이트
        trans.position = position; //플레이어 움직임

        //상호작용 키(예정)
        if (Input.GetKeyDown(KeyCode.F) && isTabel)
        {
            popupManager.OpenPopup(tabelPopup);
        }

        //인벤토리
        if (Input.GetKeyDown(KeyCode.R))
        {
            popupManager.OpenPopup(invenPopup);
        }
    }

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("tabel"))
        {
            isTabel = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("tabel"))
        {
            isTabel = false;
        }

    } 

}
