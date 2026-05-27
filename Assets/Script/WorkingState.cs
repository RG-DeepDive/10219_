using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class WorkingState : MonoBehaviour, State
{
    public Player player;
    public float rotation = 1f;
    private float time;
    private float _speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        player = GetComponent<Player>();
    }

    void Update()
    {
        time = Time.deltaTime;
        _speed = player.speed * time;
    }

    private void SetDirection()
    {
        if (Input.GetKey(KeyCode.A))
        {
            print("rotate a-direction");
            player.rotate += rotation * time;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            print("rotate d-direction");
            player.rotate -= rotation * time;
        }
        player.direction = new Vector2(Mathf.Cos(player.rotate), Mathf.Sin(player.rotate));
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
         {
            player.position.x += player.direction.x * _speed;
            player.position.y += player.direction.y * _speed;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            player.position.x -= player.direction.x * _speed;
            player.position.y -= player.direction.y * _speed;
        }
        else
        {
            player.position.x += 0;
            player.position.y += 0;
        }
    }

    public void Updating()
    {
        SetDirection();
        Move();
        //throw new System.NotImplementedException();
    }
}
