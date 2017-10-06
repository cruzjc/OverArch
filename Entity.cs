using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use of get set stuff, simplifies the getting and setting of variables
//https://www.dotnetperls.com/property
//inheritance basics
//https://www.dotnetperls.com/inheritance
//https://unity3d.com/learn/tutorials/topics/scripting/inheritance


public class Entity : MonoBehaviour {
    //level
    private float level;
    public float Level{
        get { return this.level; }
        set { this.level = value; }
    }

    //experience
    private float experience;
    public float Experience
    {
        get { return this.experience; }
        set { this.experience = value; }
    }

    //hit points
    private float hitPoints;
    public float HitPoints{
        get { return this.hitPoints; }
        set { this.hitPoints = value; }
    }

    //character stats
    ///Attack
    private float attack;
    public float Attack
    {
        get { return this.attack; }
        set { this.attack = value; }
    }
    ///Defense (not initially necessary)
    private float defense;
    public float Defense
    {
        get { return this.defense; }
        set { this.defense = value; }
    }

    //inflicts damage to entity
    public void inflictDamage(float damage){
        //calculates final damage (applies modifiers)
        float finalDamage=0;

        //subtract final damage from hitpoints
        HitPoints -= finalDamage;
    }

    //performs a basic attack based on the attack stat
    public void basicAttack(Entity target){
        target.inflictDamage(this.Attack);
    }
}
