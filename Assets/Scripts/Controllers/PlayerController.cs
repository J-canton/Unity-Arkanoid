using UnityEngine;

public class PlayerController : MonoBehaviour{
    private Rigidbody2D _player;
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
}
