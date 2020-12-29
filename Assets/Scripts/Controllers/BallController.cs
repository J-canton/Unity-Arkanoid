using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour{
    public float speed = 100.0f;
    private Rigidbody2D _ball;

    void Awake()
    {
        _ball = GetComponent<Rigidbody2D>();
    }

    void Start(){
        InitMovement();
    }

    void OnCollisionEnter2D(Collision2D col){
        if(GameStats.CurrentState == GameManager.GameState.inTheGame){
            if(col.gameObject.name == "Player"){
                float x = HitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
                Vector2 dir = new Vector2(x, 1).normalized;
                _ball.velocity = dir * speed;
            }
        }

    }

    /// <summary>
    /// Run the ball to the player
    /// </summary>
    void InitMovement()
    {
        if (GameStats.CurrentState == GameManager.GameState.inTheGame)
        {
            _ball.velocity = Vector2.up * speed;
        }
    }

    /// <summary>
    /// Bound ball
    /// </summary>
    /// <param name="ballPos"></param>
    /// <param name="playerPos"></param>
    /// <param name="playerWidth"></param>
    /// <returns></returns>
    float HitFactor(Vector2 ballPos, Vector2 playerPos, float playerWidth){
        return (ballPos.x - playerPos.x) /playerWidth;
    }
}
