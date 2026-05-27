using UnityEngine;

public class Player : MonoBehaviour
{

    public Vector2 direction;
    public Vector3 position;
    private float _rotate;
    public float rotate {
        get { return _rotate; }
        set {
            _rotate = value;
        }
    }
    public float speed = 1;
    public Transform trans;
    public State playerState;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        trans = transform;
        position = trans.position;
        rotate = 0;
        playerState = gameObject.AddComponent<WorkingState>();
            
    }

    // Update is called once per frame
    void Update()
    {
        playerState.Updating();
        trans.position = position;
        trans.rotation = Quaternion.Euler(0, 0, rotate);
    }
}
