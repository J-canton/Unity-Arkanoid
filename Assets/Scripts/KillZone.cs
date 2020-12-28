using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{
    private int _lifeLostValue = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        BallController.HideBall();
        GameManager.sharedInstance.UpdateLifes(_lifeLostValue);
        GameManager.sharedInstance.CurrentState = GameManager.GameState.lostLife;
        UIManager.uIManagerInstance.EnableButton(UIManager.uIManagerInstance.playAgainBtn);
    }
}
