using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class WalkingState : State
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
            player.direction.y = 1;

        }
        else if (Input.GetKey(KeyCode.S))
        {
            player.direction.y = -1;
        }
        else
        {
            player.direction.y = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.direction.x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            player.direction.x = 1;
        }
        else
        {
            player.direction.x = 0;
        }

            player.direction.Normalize();

        player.direction = player.direction * _speed;
        player.position += player.direction;
    }

    public override void Updating()
    {
        Move();
        //throw new System.NotImplementedException();
    }
}
