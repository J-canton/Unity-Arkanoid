using UnityEngine;

public class BlockController : MonoBehaviour{
    public int blockValue;

    /// <summary>
    /// When block is destroy add blockValue to _totalScore in GameManager
    /// </summary>
    /// <param name="collisionInfo"></param>
   void OnCollisionEnter2D(Collision2D collisionInfo){
       Destroy(gameObject);
       GameManager.sharedInstance.UpdateScore(blockValue);
    }
}
