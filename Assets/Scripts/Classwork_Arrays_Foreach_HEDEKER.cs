using UnityEngine;

// L9 - Arrays & foreach (In-Class Classwork)
// Work through the TODOs in order. Attach this to an empty GameObject and press Play to test.
// Directions:
//   Section A - read the code and write your predicted answer, then test it.
//   Section B - write the code for each task.
//   Section C - solve each mini-interview problem (the approach is up to you).
public class Classwork_Arrays_Foreach : MonoBehaviour
{
    void Start()
    {
        // For Section A, use this array:
        int[] loot = { 5, 10, 15, 20 };

        // ============================================================
        // SECTION A: Trace & Predict (predict, then test)
        // ============================================================
        // A1. loot[0]
        // Answer: <5>
        //
        // A2. loot[3]
        // Answer: <20>
        //
        // A3. loot.Length
        // Answer: <4>
        //
        Debug.Log(loot[loot.Length - 1]);
        // A4. loot[loot.Length - 1]
        // Answer: <20>
        //
        // A5. loot[4]        (valid, or ERROR?)
        // Answer: <ERROR>
        //
        // A6. loot[-1]       (valid, or ERROR?)
        // Answer: <ERROR>
        //
        // A7. What does this print?
        //     foreach (int g in loot)
        //     {
        //         Debug.Log(g);
        //     }
        // Answer: <5
        // 10
        // 15
        // 20>
        //
        // A8. What does this print?
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Debug.Log(loot[i]);
        //     }
        // Answer: <5
        // 10
        // 15>

        // ============================================================
        // SECTION B: Application (write the code)
        // ============================================================
        // B1. Declare three arrays (write the full lines):
        //     a) three room names as strings: "Hall", "Vault", "Cell"
        string[] roomNames = { "Hall", "Vault", "Cell" };
        //     b) four potion counts as ints: 2, 4, 6, 8
        int[] Potions = { 2, 4, 6, 8 };
        //     c) an empty array that holds 5 ints (all start at 0)
        int[] emptyArray = new int[4];
        //
        // B2. TOTAL LOOT: add up every value in the loot array above and print
        //     the total.
        int totalLoot = 0;
        for (int l = 0; l < loot.Length; l++)
        {
            totalLoot += loot[l];
        }
        Debug.Log(totalLoot);
        //
        // B3. INVENTORY LIST: given a string[] of items, print each item together
        //     with its index, like "0: torch".
        string[] items = { "torch", "sword", "potion", "shield", "potion"};
        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log(i + ": " + items);
        }
        //
        // B4. UPGRADE A SLOT: change the third item of an int[] to a new value,
        //     then print the whole array.
        for (int i = 0; i < items.Length; i++)
        {
            if (i % 3 == 0)
            {
                items[i] = "Worm";
            }
        }

        for (int i = 0; i < items.Length; i++)
        {
            Debug.Log(items);
        }
        // ============================================================
        // SECTION C: Mini-Interview (write the code)
        // ============================================================
        // C1. STRONGEST ENEMY: given int[] enemyHealth, find and print the
        //     largest value (don't use a built-in Max).
        int[] enemyHealth = { 10, 40, 0, 63, 2, 59};
        int maxHealth = 0;
        for (int n = 0; n < enemyHealth.Length; n++)
        {
            if (enemyHealth[n] > maxHealth)
            {
                maxHealth = enemyHealth[n];
            }
        }
        Debug.Log(maxHealth);
        //
        // C2. COUNT THE POTIONS: given a string[] of items and a target word
        //     (say "potion"), print how many times the target appears.
        int potionCount = 0;
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == "potion")
            {
                potionCount += 1;
            }
        }
        Debug.Log(potionCount);
        //
        // C3. REVERSE ROLL CALL: given a string[] of party members, print the
        //     names from last to first.
        string[] partyMembers = { "Mark", "Jessie", "Gail", "Keith", "Becka" };

        for (int p = partyMembers.Length - 1; p == 0; p--)
        {
            Debug.Log(partyMembers[p]);
        }
        //
        // C4. SURVIVORS: given int[] enemyHealth, print how many enemies are
        //     still alive (health above 0).
        int liveEnemies = 0;
        for (int n = 0; n < enemyHealth.Length; n++)
        {
            if (enemyHealth[n] > 0)
            {
                liveEnemies += 1;
            }
        }
        //
        // C5. SORT THE LOOT: given an int[] of values in any order, rearrange
        //     them so they run from smallest to largest, then print them in order.
        int[] values = { 54, 82, 91, 55, 3, 12, 38 };
        int startValue = values[values.Length / 2];
        

        //
        // C6. FIND IN THE SORTED LOOT: using the now-sorted values from C5, look
        //     for a particular value and print whether it is in the list and, if
        //     so, at what index.
        //
        // C7. PALINDROME WORD: given a word (say "level"), print whether it reads
        //     the same forwards and backwards.
        string palindrome = "level";
        int palindromeCount = 0;
        for (int p = 0; p < palindrome.Length; p++)
        {
            Debug.Log(palindrome[palindrome.Length - 1 - p]);
            Debug.Log(palindrome[p]);
            if (palindrome[palindrome.Length - 1 - p] == palindrome[p])
            {
                palindromeCount += 1;
            }
        }
        if (palindromeCount == palindrome.Length)
        {
            Debug.Log("That's a palindrome.");
        }
    }
}
