// Lecture 14 in-class example - Inventory_InputDemo.cs
using UnityEngine;

public class Inventory_InputDemo
{
    public Item_InputDemo[] items = new Item_InputDemo[8];
    public int count = 0;

    public void Add(Item_InputDemo item)
    {
        if (count >= items.Length)
        {
            Debug.Log("Your pack is full.");
            return;
        }
        items[count] = item;
        count++;
    }

    public Item_InputDemo FindByName(string name)
    {
        for (int i = 0; i < count; i++)
        {
            if (items[i].Name == name)
            {
                return items[i];
            }
        }
        return null;
    }

    public void ShowAll()
    {
        Debug.Log("-- Your pack --");
        if (count == 0)
        {
            Debug.Log("  (empty)");
            return;
        }
        for (int i = 0; i < count; i++)
        {
            Debug.Log("  " + (i + 1) + ". " + items[i].Name);
        }
    }
}
