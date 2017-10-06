using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//idea of having code outside of scenes
//http://answers.unity3d.com/questions/45680/scriptscode-sitting-outside-of-individual-scenes.html
//https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html

public class OverArch : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        stateMachine();
	}
    

    public enum gameState { onGameStart, inGame, paused, inventory, exit }
    public gameState currentState;
    void stateMachine(){
        switch(currentState){
        case gameState.onGameStart:
        //load intro sequence
            break;

        case gameState.inGame:
        //loads initial scene
            break;

        case gameState.paused:
        //pauses assets/time
        //initializes different ui
            break;

        case gameState.inventory:
        //bring up ui
            break;

        case gameState.exit:
        //quits game
            break;

        default:
            break;

        }
    }
}