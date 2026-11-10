// Lecture 14 in-class example - DungeonInputDemo.cs   (the controller)
// The class-based dungeon, driven by INPUT. It uses the same object model you
// built for the Classes homework (Item, Inventory, Enemy, Room, Player), but
// every class here has "_InputDemo" added to its name so it can live in the same
// project as your homework classes without a compiler clash. Each class is in
// its own file: Item_InputDemo.cs, Inventory_InputDemo.cs, Enemy_InputDemo.cs,
// Player_InputDemo.cs, Room_InputDemo.cs.
// Input comes through the new Input System's InputAction fields; bind each one
// to a key in the Inspector:
//   NextRoom / PrevRoom move   Pickup   Attack   Inventory   Look
// A room's enemy blocks the exits, so you must defeat it before you can move on.
// Attach this script to a GameObject and press Play.
using UnityEngine;
using UnityEngine.InputSystem;   // Unity's new Input System

public class DungeonInputDemo : MonoBehaviour
{
    // INPUT ACTIONS - bind each one to a key in the Inspector
    public InputAction NextRoomAction;
    public InputAction PrevRoomAction;
    public InputAction PickupAction;
    public InputAction AttackAction;
    public InputAction InventoryAction;
    public InputAction LookAction;

    private Player_InputDemo player;
    private Room_InputDemo[] rooms;
    private int currentRoom = 0;
    private int combatTurn = 0; 

    void Start()
    {
        NextRoomAction.Enable();
        PrevRoomAction.Enable();
        PickupAction.Enable();
        AttackAction.Enable();
        InventoryAction.Enable();
        LookAction.Enable();

        player = new Player_InputDemo();

        rooms = new Room_InputDemo[]
        {
            new Room_InputDemo("The Entrance Hall", "A torch flickers on the wall.",
                12, null, new Item_InputDemo("Torch", 0, 0)),
            new Room_InputDemo("The Guard Room", "A rusty sword rests on a table.",
                0, new Enemy_InputDemo("Goblin", 20, 8, 2, 10, 1), new Item_InputDemo("Rusty Sword", 7, 0)),
            new Room_InputDemo("The Armoury", "Dented armour lines the walls.",
                5, null, new Item_InputDemo("Shield", 0, 4)),
            new Room_InputDemo("The Flooded Lair", "Ankle-deep water; something skitters.",
                0, new Enemy_InputDemo("Giant Spider", 24, 6, 1, 13, 2), null),
            new Room_InputDemo("The Vault", "Gold gleams behind an open gate.",
                30, null, new Item_InputDemo("Gold Crown", 0, 0))
        };

        Debug.Log("=== THE SUNLESS KEEP ===");
        rooms[currentRoom].Enter(player);
        ShowActions();
    }

    void Update()
    {
        if (!player.IsAlive())
        {
            return;   // the hero has fallen; ignore input
        }

        Room_InputDemo room = rooms[currentRoom];

        if (NextRoomAction.WasPressedThisFrame())
        {
            TryMove(1);
        }
        else if (PrevRoomAction.WasPressedThisFrame())
        {
            TryMove(-1);
        }
        else if (PickupAction.WasPressedThisFrame())
        {
            room.PickUpItem(player);
        }
        else if (AttackAction.WasPressedThisFrame())
        {
            FightRound(room, player);
        }
        else if (InventoryAction.WasPressedThisFrame())
        {
            player.ShowInventory();
        }
        else if (LookAction.WasPressedThisFrame())
        {
            room.Describe();
        }
    }

    void TryMove(int step)
    {
        Room_InputDemo room = rooms[currentRoom];
        if (room.HasEnemy())
        {
            Debug.Log("You cannot leave while the " + room.GetEnemy().GetName() + " still stands. Attack it!");
            return;
        }
        int next = currentRoom + step;
        if (next < 0 || next >= rooms.Length)
        {
            Debug.Log("There is no room that way.");
            return;
        }
        currentRoom = next;
        combatTurn = 0;   // a fresh room means a fresh fight
        rooms[currentRoom].Enter(player);
        ShowActions();
    }

    void FightRound(Room_InputDemo room, Player_InputDemo player)
    {
        if (!room.HasEnemy())
        {
            Debug.Log("There is nothing to attack here.");
            return;
        }
        Enemy_InputDemo enemy = room.GetEnemy();
        combatTurn++;
        player.Attack(enemy);
        if (!enemy.IsAlive())
        {
            Debug.Log("The " + enemy.GetName() + " is defeated! The way is clear.");
            room.RemoveEnemyFromRoom();
            return;
        }
        if (enemy.AttacksOnTurn(combatTurn))
        {
            enemy.AttackPlayer(player);
            if (!player.IsAlive())
            {
                Debug.Log("You have fallen. GAME OVER.");
            }
        }
    }

    void ShowActions()
    {
        Debug.Log("-- NextRoom / PrevRoom move   Pickup   Attack   Inventory   Look --");
    }
}
