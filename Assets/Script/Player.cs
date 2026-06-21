using NUnit.Framework;
using System.Collections.Generic;
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

    public List<Item> inventory;

    void Start()
    {
        trans = transform;
        position = trans.position;
        rotate = 0;
        state = gameObject.GetComponent<WalkingState>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        popupManager = gameObject.GetComponent<PopupManager>();
    }

    // Update is called once per frame
    void Update()
    {
        state.Updating();
        trans.position = position;
        //trans.rotation = Quaternion.Euler(0, 0, rotate);

        if (Input.GetKeyDown(KeyCode.F) && isTabel)
        {
            popupManager.OpenPopup(tabelPopup);
        }

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
