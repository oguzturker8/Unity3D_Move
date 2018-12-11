using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel(){
    	completeLevelUI.SetActive(true);
    }
    public void EndGame(){
    	if(gameHasEnded == false){
    		gameHasEnded = true;
    		Debug.Log("Game Over");
    		Invoke("Restart", restartDelay);
    	}
    }
}