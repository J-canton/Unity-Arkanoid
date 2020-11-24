using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameStatus {menu, inTheGame, gameOver};

public class GameManager : MonoBehaviour{
    public static GameManager sharedInstance;

    public int lifes = 0;
    public GameStatus currentState;
    public Canvas menuCanvas;
    public Canvas gameCanvas;
    public Canvas gameOverCanvas;


    void Awake(){
        sharedInstance = this;
    }
    // Start is called before the first frame update
    void Start(){
        currentState = GameStatus.menu;
    }

    // Update is called once per frame
    void Update(){}

    public void StartGame(){
        OnChangeState(GameStatus.inTheGame);
        EnabledMenus();
    }

    public void EndGame(){
        OnChangeState(GameStatus.gameOver);
        EnabledMenus();
    }

    public void BackToMenu(){
        OnChangeState(GameStatus.menu);
        EnabledMenus();
    }


    public void OnChangeState(GameStatus otherGameState){
        switch(otherGameState){
            case GameStatus.menu:
                currentState = otherGameState;
                break;
            case GameStatus.inTheGame:
                currentState = otherGameState;
                break;
            case GameStatus.gameOver:
                currentState = otherGameState;
                break;    
            default:
                currentState = otherGameState;
                break;    
                
        }
    }

    public void EnabledMenus(){
        if(currentState == GameStatus.menu){
            menuCanvas.enabled = true;
        }else if(currentState == GameStatus.inTheGame){
            menuCanvas.enabled = false;
        }else if(currentState == GameStatus.gameOver){
            menuCanvas.enabled = false;
        }
    }
}
