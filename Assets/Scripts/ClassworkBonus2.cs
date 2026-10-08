using UnityEngine;

public class ClassworkBonus2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // --- Trace & Predict ---
        // 1. increment: post (wave++) vs pre (++wave)
             int wave = 3;
             int shown = wave++;
             int next = ++wave;
             Debug.Log(shown + " " + next + " " + wave);
        //     My answer:  3 5 5
        //
        // 2. three separate ifs - which run?
        //     bool locked = true;
        //     bool trapped = false;
        //     bool glowing = true;
        //     if (locked)
        //     {
        //         Debug.Log("It's locked.");
        //     }
        //     if (trapped)
        //     {
        //         Debug.Log("A trap springs!");
        //     }
        //     if (glowing)
        //     {
        //         Debug.Log("It glows faintly.");
        //     }
        //     My answer: Locked and Glowing
        //
        // 3. do-while - how many times does the body run?
        //     int potions = 0;
        //     int drunk = 0;
        //     do
        //     {
        //         drunk++;
        //         potions--;
        //     }
        //     while (potions > 0);
        //     Debug.Log(drunk);
        //     My answer: ______________________________________
        //
        // 4. string operations
        //     string spell = "Fireball";
        //     Debug.Log(spell.Length);
        //     Debug.Log(spell.ToLower());
        //     Debug.Log(spell[spell.Length - 1]);
        //     Debug.Log(spell.Substring(0, 4));
        //     My answer: ______________________________________

        // --- Fix the Bug ---
        // 5. Meant to print the odd numbers 1..9.
        //     int i = 1;
        //     while (i <= 9)
        //     {
        //         if (i % 2 == 0)
        //         {
        //             continue;
        //         }
        //         Debug.Log(i);
        //         i++;
        //     }
        //
        // 6. Meant to print each letter of the word
        //     string word = "sword";
        //     for (int j = 0; j <= word.Length; j++)
        //     {
        //         Debug.Log(word[j]);
        //     }
        //
        // 7. Meant to count down from 5 to 1
        //     for (int k = 5; k > 0; k++)
        //     {
        //         Debug.Log(k);
        //     }

        // --- Application ---
        // 8. COMBO METER: you land some number of hits in a row. Each hit is
        //     worth 10 points, but every 5th hit is a combo worth double (20).
        //     Print the running score after each hit, then the final score based
        //     on a variable number of hits. 
        // 9. TORCH SUPPLY: you have some gold; torches cost 7 each. Print how
        //     many torches you can buy and how much gold is left over. If nothing
        //     is left over, also print "Perfect change!"

        // --- Mini-Interview ---
        // 10. SUM OF SQUARES: given int n (try 5), print 1*1 + 2*2 + ... + n*n. (55)
        // 11. FACTORIAL: given int n (try 6), print n! = 1 * 2 * ... * n. (720)
        // 12. SUM OF DIGITS: given int n (try 472), print the sum of its digits.
        // 13. PERFECT NUMBER: given int n (try 28), a number is "perfect" when its
        //      divisors below it add up to itself (28 = 1+2+4+7+14). Print whether
        //      n is perfect.
        // 14. FIBONACCI: print the first n numbers of the Fibonacci sequence
        //      (each is the sum of the previous two, starting 0, 1).
        // 15. GCD: given two ints a and b (try 48 and 36), print their greatest
        //      common divisor (the largest number that divides both evenly).
        // 16. NUMBER PALINDROME: given int n (try 12321), print whether it reads
        //      the same forwards and backwards.
        // 17. COLLATZ: given int n (try 6), repeat until n becomes 1: if n is
        //      even, halve it; if odd, do 3*n + 1. Print each value, then the
        //      number of steps it took.
        // 18. REVERSE A STRING: given a string word (try "dungeon"), print it
        //      backwards.
        // 19. COUNT VOWELS: given a string phrase, print how many vowels
        //      (a, e, i, o, u) it contains.

        // --- string parsing (walk the characters by index) ---
        // 20. COUNT A LETTER: given a word (try "sunless") and a letter (try
        //      's'), print how many times that letter appears.
        // 21. STRING PALINDROME: given a word (try "level"), print whether it
        //      reads the same forwards and backwards by comparing the characters
        //      at both ends and working inward.
        // 22. CENSOR THE VOWELS: given a word (try "dungeon"), build and print a
        //      new string that is the same but with every vowel replaced by a '*'
        //      (so "dungeon" becomes "d*ng**n").
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
