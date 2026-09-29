using UnityEngine;

// L8 - Loops (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class Classwork_Loops : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: How Many Times Does the Body Run? (predict, then test)
        // ============================================================
        // 1.
        //     int i = 0;
        //     while (i < 5)
        //     {
        //         i++;
        //     }
        // Answer: <5>
        //
        // 2.
        //     int i = 0;
        //     while (i < 0)
        //     {
        //         i++;
        //     }
        // Answer: <1>
        //
        // 3.
        //     int i = 0;
        //     do
        //     {
        //         i++;
        //     }
        //     while (i < 3);
        // Answer: <4>
        //
        // 4.
        //     for (int i = 0; i < 4; i++)
        //     {
        //     }
        // Answer: <3>
        //
        // 5.
        //     for (int i = 1; i <= 3; i++)
        //     {
        //     }
        // Answer: <3>

        // ============================================================
        // A2: Trace the Final Value
        // ============================================================
        // 6. What is n at the end?
        //     int n = 1;
        //     while (n < 100)
        //     {
        //         n *= 2;
        //     }
        // Answer: <100>
        //
        // 7. What is s at the end?
        //     int s = 0;
        //     for (int i = 1; i <= 4; i++)
        //     {
        //         s += i;
        //     }
        // Answer: <10>

        // ============================================================
        // A3: while, do-while, or for? (answer in a comment)
        // ============================================================
        // 8. Repeat a known number of times.
        // Answer: <for>
        // 9. Ask for a password; they must try at least once.
        // Answer: <do-while>
        // 10. Keep attacking while the enemy has health.
        // Answer: <while>

        // ============================================================
        // A4: break or continue? (answer in a comment)
        // ============================================================
        // 11. Stop searching once you find the item.
        // Answer: <break>
        // 12. Skip enemies that are already dead, keep checking the rest.
        // Answer: <continue>

        // ============================================================
        // A5: Spot the Bug (then write the fix)
        // ============================================================
        // 13. This is meant to print 0 through 4, but it has two problems:
        //     for (int i = 0; i < 5; i++);
        //     Debug.Log(i);
        //
        //(Replace the semicolon next to 5 with a comma, and remove the semicolon at the end)
        //
        // 14. This is meant to print 0 through 4, but something is missing:
        //     int i = 0;
        //     while (i < 5)
        //     {
        //         Debug.Log(i);
        //     }
        //
        //(There's nothing incrementing the value of i, creating an infinite loop)

        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 15. Use a for loop to print the numbers 1 through 10.
        int fifteen = 0;
        while (fifteen < 10)
        {
            fifteen++;
            Debug.Log(fifteen);
        }

        // 16. Use a while loop to add up 1 through 100 and print the total.
        int sixteen = 0;
        while (sixteen < 100)
        {
            sixteen++;
        }
        Debug.Log(sixteen);

        // 17. Loop 1 through 10, but use continue to skip 5 and break at 8.
        //     Which numbers print?
        int seventeen = 0;
        while (seventeen < 10)
        {
            seventeen++;
            if (seventeen == 5)
            {
                continue;
            }

            if (seventeen == 8)
            {
                break;
            }
            Debug.Log(seventeen);
        }
        // Answer: <1, 2, 3, 4, 6, 7>

        // 18. FIZZBUZZ (1 to 20): print the numbers 1 through 20, but print
        //     "Fizz" if the number is divisible by 3, print "Buzz" if it is
        //     divisible by 5, and print "FizzBuzz" if it is divisible by both
        //     3 and 5.
        int eighteen = 0;
        while (eighteen < 20)
        {
            eighteen++;
            if (eighteen % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            if (eighteen % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            if (eighteen % 3 == 0 && eighteen % 5 == 0)
            {
                Debug.Log("FizzBuzz");
            }
        }

        // 19. IS PRIME: given int n (greater than 1), print whether it is
        //     prime. Loop from 2 to n - 1; if any value divides n evenly it is
        //     not prime; use break to stop early.
        int n = 13;
        for (int s = 2; s < n - 1; s++)
        {
            if ((n / s) is int)
            {
                Debug.Log("Prime!");
            }
        }

        // 20. COUNTDOWN: use a for loop to print a countdown from 5 down to 1,
        //     then print "Go!".
        int countdown = 6;
        while (countdown > 1)
        {
            countdown--;
            Debug.Log(countdown);
            if (countdown == 1)
            {
                Debug.Log("Go!");
            }
        }
    }
}
