// Lecture 14 in-class example - Enemy_InputDemo.cs
using UnityEngine;

public class Enemy_InputDemo
{
    private string name;
    private int health;
    private int attack;
    private int defense;
    private int armorClass;
    public int attackSpeed;   // 1 = every turn, 2 = every other, 3 = every third

    public Enemy_InputDemo(string name, int health, int attack, int defense, int armorClass, int attackSpeed)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.defense = defense;
        this.armorClass = armorClass;
        this.attackSpeed = attackSpeed;
    }

    public int GetHealth()
    {
        return health;
    }

    public int GetAttack()
    {
        return attack;
    }

    public int GetDefense()
    {
        return defense;
    }

    public int GetArmorClass()
    {
        return armorClass;
    }

    public int GetAttackSpeed()
    {
        return attackSpeed;
    }

    public string GetName()
    {
        return name;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    public bool AttacksOnTurn(int turnNumber)
    {
        return turnNumber % attackSpeed == 0;
    }

    // the enemy rolls to hit the player and, on a hit, deals its damage
    public void AttackPlayer(Player_InputDemo player)
    {
        int roll = Random.Range(1, 21);
        if (roll >= player.GetArmorClass())
        {
            int hit = attack - player.GetDefense();
            if (hit < 0)
            {
                hit = 0;
            }
            player.TakeDamage(hit);
            Debug.Log("The " + name + " hits you for " + hit + ". " + player.HealthStatus());
        }
        else
        {
            Debug.Log("The " + name + " swings and misses.");
        }
    }
}
