// Lecture 14 in-class example - Room_InputDemo.cs
using UnityEngine;

public class Room_InputDemo
{
    private string name;
    private string description;
    private int gold;
    private bool visited;
    private Enemy_InputDemo enemy;   // may be null
    private Item_InputDemo item;     // may be null

    public Room_InputDemo(string name, string description, int gold,
        Enemy_InputDemo enemy, Item_InputDemo item)
    {
        this.name = name;
        this.description = description;
        this.gold = gold;
        this.enemy = enemy;
        this.item = item;
        this.visited = false;
    }

    public bool HasEnemy()
    {
        return enemy != null;
    }

    public Enemy_InputDemo GetEnemy()
    {
        return enemy;
    }

    public void RemoveEnemyFromRoom()
    {
        enemy = null;
    }

    public bool HasBeenVisited()
    {
        return visited;
    }
    public void Enter(Player_InputDemo player)
    {
        Debug.Log("");
        Debug.Log(name);
        if (!visited)
        {
            Debug.Log(description);
            visited = true;
            if (gold > 0)
            {
                player.CollectGold(gold);
                gold = 0;
            }
        }
        DescribeContents();
    }

    public void Describe()
    {
        Debug.Log(name);
        Debug.Log(description);
        DescribeContents();
    }

    void DescribeContents()
    {
        if (gold > 0)
        {
            Debug.Log("There is " + gold + " gold here.");
        }
        if (enemy != null)
        {
            Debug.Log("A " + enemy.GetName() + " (" + enemy.GetHealth() + " HP) guards this room.");
        }
        if (item != null)
        {
            Debug.Log("You see a " + item.Name + " here.");
        }
        if (enemy == null && item == null && gold == 0)
        {
            Debug.Log("The room is quiet.");
        }
    }

    // Pickup belongs here, because the ROOM owns the item: hand it to the player,
    // then clear it so the room no longer holds it.
    public void PickUpItem(Player_InputDemo player)
    {
        if (item == null)
        {
            Debug.Log("There is nothing here to pick up.");
            return;
        }
        player.PickUp(item);
        item = null;   // null out the item after the player takes it
    }
}
