using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//awake vs start functions
//http://answers.unity3d.com/questions/382658/use-of-awake-vs-start.html

public class PlayerCharacter : Entity, IEntity {

	// Use this for initialization
	void Start () {
        initializeStartingStats();
        //Debug.Log(this.Level);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //initialize starting stats
    void initializeStartingStats(){
        this.Level = 1;
        this.Experience = 0;
        this.HitPoints = 100;
        this.Attack = 10;
        this.Defense = 5;
    }

    //inflicts damage to entity
    public new void inflictDamage(float damage)
    {
        //Debug.Log("Player taking damage:" + damage);


        //calculates final damage (applies modifiers)
        float finalDamage = 0;

        //subtract final damage from hitpoints
        HitPoints -= finalDamage;
    }

    //performs a basic attack based on the attack stat
    public void basicAttack(IEntity target)
    {
        target.inflictDamage(this.Attack);
    }
}
