using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class InBattle : MonoBehaviour {
    bool isTurnBased;


	// Use this for initialization
	void Start () {
        sampleBattle();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public enum turnBasedState { playerTurn, otherSide };
    public turnBasedState currentState;
    void turnBasedStateMachine(){
        switch(currentState){
            case turnBasedState.playerTurn:
                Debug.Log("Player Turn");
                playerChoice();
                break;

            case turnBasedState.otherSide:
                Debug.Log("Other Turn");
                otherSideChoice();
                break;

            default:
                break;

        }
        cycleTurn();
    }

    //player side entities
    public List<IEntity> playerSide;

    //other side entities
    public List<IEntity> otherSide;

     //cycles the turnBasedStateMachine
    void cycleTurn(){
        if(currentState==turnBasedState.playerTurn){ currentState = turnBasedState.otherSide; }
        else if (currentState == turnBasedState.playerTurn) { currentState = turnBasedState.otherSide; };
    }


    //to be called if an entity is removed
    bool checkIfSideIsEmpty(){
        if(playerSide.Count==0){
            //initiate player defeat sequence
            return true;
        }else if(otherSide.Count==0){
            //initiate player win sequence
            return true;
        }

        return false;
    }

    //player defeat sequence
    void playerDefeat(){

    }

    //player win sequence
    void playerWin(){
       


    }


    //turn based, player choice
    void playerChoice(){
        //maybe could use coroutines?
        //initiallize ui


        //get player input for each party member


        //playercharacter
        Debug.Log("Press '1' to do a basic attack");
        IEntity currentCharacter = playerSide[0];
        IEntity targetCharacter = otherSide[0];

        while(true){
            if (CrossPlatformInputManager.GetButton("1")){
                currentCharacter.basicAttack(targetCharacter);
                Debug.Log("Performed basic attack");
                break; 
            
            }


        }

    }

    //turn based, other side choice
    void otherSideChoice(){

    }


    //sample battle
    void sampleBattle(){
        GameObject player = Instantiate(object);

        IEntity player = gameObject.AddComponent<PlayerCharacter>();
        IEntity opponent = gameObject.AddComponent<BasicEnemy>();

        playerSide.Add(player);
        otherSide.Add(opponent);

        while(true){
            turnBasedStateMachine();
        }
    }
}
