using UnityEngine;

public class Player : MonoBehaviour
{

    private static Player instance;

    //void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Destroy(gameObject);
    //        return;
    //    }

    //    instance = this;
    //    DontDestroyOnLoad(gameObject);
    //}

    public Vector3 direction;
    public Vector3 position;
    private float _rotate;
    public float rotate { get; set; }
    public float speed = 1;
    public Transform trans;
    public State playerState;
    private Rigidbody2D rb;
    public bool isTabel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = transform;
        position = trans.position;
        rotate = 0;
        playerState = gameObject.AddComponent<WorkingState>();
        rb = gameObject.GetComponent<Rigidbody2D>();
            
    }

    // Update is called once per frame
    void Update()
    {
        playerState.Updating();
        trans.position = position;
        trans.rotation = Quaternion.Euler(0, 0, rotate);

        if (Input.GetKeyDown(KeyCode.F) && isTabel)
        {
            print("open tabel");
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
