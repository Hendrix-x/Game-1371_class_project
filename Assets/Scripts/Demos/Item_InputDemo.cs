// Lecture 14 in-class example - Item_InputDemo.cs
using UnityEngine;

public class Item_InputDemo
{
    public string Name;
    public int AttackBonus;
    public int DefenseBonus;

    public Item_InputDemo(string name, int attackBonus = 0, int defenseBonus = 0)
    {
        Name = name;
        AttackBonus = attackBonus;
        DefenseBonus = defenseBonus;
    }
}
