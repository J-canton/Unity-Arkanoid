using UnityEngine;

public class BlockController : MonoBehaviour{
    public int blockValue;

    /// <summary>
    /// When block is destroy add blockValue to _totalScore in GameManager
    /// </summary>
    /// <param name="collisionInfo"></param>
   void OnCollisionEnter2D(Collision2D collisionInfo){
        PlaySound();
        GameManager.gameManagerInstance.UpdateScore(blockValue);
        Destroy(gameObject,0.09f);       
    }

    void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
}
