using UnityEngine;

public class PlayerController : MonoBehaviour{
    private static Rigidbody2D _player;
    private float _hInput;
    public float speed = 150.0f;
    private static Vector2 _initialPosition = new Vector2(0, -31);

    void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _hInput = Input.GetAxis("Horizontal"); 
    }

    void FixedUpdate()
    {
        if (GameManager.sharedInstance.CurrentState == GameManager.GameState.inTheGame)
        {
            _player.velocity = Vector2.right * _hInput * speed;
        }
    }


    public static void InitPlayerPosition()
    {
        _player.transform.position =_initialPosition;
    }
}
