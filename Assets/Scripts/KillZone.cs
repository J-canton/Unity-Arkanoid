using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private int _lifeLostValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        GameManager.gameManagerInstance.UpdateState(GameManager.GameState.lostLife);
        BallController.HideBall();
        GameManager.gameManagerInstance.UpdateLifes(GameStats.Lifes - _lifeLostValue);
    }
}
