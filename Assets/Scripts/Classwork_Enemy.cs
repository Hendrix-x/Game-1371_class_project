// Lecture 13 classwork - Enemy.cs
// A GENERIC enemy blueprint. One class, many kinds of enemy: you make a goblin
// and an ogre from this SAME class, each with its own name, health, and attack.
// (In your project this file is named Enemy.cs, matching the class inside it.)
using UnityEngine;

public class Enemy
{
    public string name;    // what this enemy is called
    public int health;     // how much health this enemy has
    public int attack;     // how much damage it deals on a hit

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public void Describe()
    {
        Debug.Log(name + " (HP " + health + ", ATK " + attack + ")");
    }
}
