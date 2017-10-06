using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : Entity,IEntity {

	// Use this for initialization
	void Start () {
        initializeStartingStats();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //initialize starting stats
    void initializeStartingStats()
    {
        this.Level = 1;
        this.Experience = 0;
        this.HitPoints = 20;
        this.Attack = 10;
        this.Defense = 1;
    }

    public void basicAttack(IEntity target){
        target.inflictDamage(this.Attack);
    }
}
