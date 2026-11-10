// Lecture 14 in-class example - Player_InputDemo.cs
using UnityEngine;

public class Player_InputDemo
{
    private string name;
    private int health;
    private int attack;
    private int defense;
    private int armorClass;
    private int gold;
    public Inventory_InputDemo Inventory;

    const int maxHealth = 100;
    const int lowHealth = 30;

    public Player_InputDemo()
    {
        name = "Hero";
        health = 100;
        attack = 5;
        defense = 0;
        armorClass = 12;
        gold = 0;
        Inventory = new Inventory_InputDemo();
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

    public string GetName()
    {
        return name;
    }

    public void CollectGold(int amount)
    {
        gold += amount;
        Debug.Log("You gather " + amount + " gold. Gold is now " + gold + ".");
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health < 0)
        {
            health = 0;
        }
    }

    public string HealthStatus()
    {
        if (health <= 0)
        {
            return "You have fallen.";
        }
        else if (health < lowHealth)
        {
            return "Health " + health + " (wounded).";
        }
        else
        {
            return "Health " + health + ".";
        }
    }

    public bool IsAlive()
    {
        return health > 0;
    }

    // picking up an item adds it to the inventory and applies its bonuses
    public void PickUp(Item_InputDemo item)
    {
        Inventory.Add(item);
        attack += item.AttackBonus;
        defense += item.DefenseBonus;
        Debug.Log("You pick up the " + item.Name + ".");
    }

    public bool HasItem(string itemName)
    {
        return Inventory.FindByName(itemName) != null;
    }

    // the player rolls to hit the enemy and, on a hit, deals its damage
    public void Attack(Enemy_InputDemo enemy)
    {
        int roll = Random.Range(1, 21);
        if (roll >= enemy.GetArmorClass())
        {
            int damage = attack - enemy.GetDefense();
            if (roll == 20)
            {
                damage = attack * 2 - enemy.GetDefense();
                Debug.Log("CRITICAL! You hit the " + enemy.GetName() + " for " + damage + ".");
            }
            else
            {
                Debug.Log("You hit the " + enemy.GetName() + " for " + damage + ".");
            }
            enemy.TakeDamage(damage);
        }
        else
        {
            Debug.Log("You swing at the " + enemy.GetName() + " and miss.");
        }
    }

    public void ShowInventory()
    {
        Inventory.ShowAll();
    }
}
