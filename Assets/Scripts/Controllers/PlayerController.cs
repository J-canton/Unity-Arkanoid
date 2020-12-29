using UnityEngine;

public class PlayerController : MonoBehaviour{
    private static Rigidbody2D _player;
    private static Vector2 initPlayerPosition = new Vector2(0, -32);
    private float _hInput;

    public float speed = 150.0f;

    void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _hInput = Input.GetAxis("Horizontal"); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
    }

    void FixedUpdate()
    {
        if (GameStats.CurrentState == GameManager.GameState.inTheGame)
        {
           _player.velocity = Vector2.right * _hInput * speed;
        }
    }

    public static void InitPositionPlayer()
    {
        _player.transform.position = initPlayerPosition;
    }
}
