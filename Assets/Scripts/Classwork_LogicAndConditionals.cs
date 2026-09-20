using UnityEngine;

// L7 - Comparison, Logic & Conditionals (In-Class Reps)
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
public class L7_Logic_Conditionals_Reps : MonoBehaviour
{
    void Start()
    {
        // ============================================================
        // A1: True or False (answer in a comment)
        // ============================================================
        // 1. 5 == 5
        // Answer: <YOUR ANSWER HERE>
        // 2. 5 != 5
        // Answer: <YOUR ANSWER HERE>
        // 3. 7 > 3
        // Answer: <YOUR ANSWER HERE>
        // 4. 7 < 3
        // Answer: <YOUR ANSWER HERE>
        // 5. 4 >= 4
        // Answer: <YOUR ANSWER HERE>
        // 6. 6 <= 2
        // Answer: <YOUR ANSWER HERE>

        // ============================================================
        // A2: Evaluate the Logic (write the result)
        // ============================================================
        // 7. true && false
        // Answer: <YOUR ANSWER HERE>
        // 8. false || true
        // Answer: <YOUR ANSWER HERE>
        // 9. !true
        // Answer: <YOUR ANSWER HERE>
        // 10. (2 > 1) && (3 > 2)
        // Answer: <YOUR ANSWER HERE>

        // These values are shared by A3, A5 and A6 below.
        int health = 20;
        int gold = 100;
        bool hasKey = true;

        // ============================================================
        // A3: Scenario - True or False (health = 20, gold = 100, hasKey = true)
        // ============================================================
        // 11. health < 30
        // Answer: <YOUR ANSWER HERE>
        // 12. hasKey && health > 50
        // Answer: <YOUR ANSWER HERE>
        // 13. !hasKey
        // Answer: <YOUR ANSWER HERE>
        // 14. gold >= 100 || hasKey
        // Answer: <YOUR ANSWER HERE>

        // ============================================================
        // A4: Predict What Prints (write your prediction, then test)
        // ============================================================
        // 15.
        //     int h = 0;
        //     if (h <= 0)
        //     {
        //         Debug.Log("dead");
        //     }
        //     else
        //     {
        //         Debug.Log("alive");
        //     }
        // Answer: <YOUR ANSWER HERE>
        //
        // 16.
        //     int s = 75;
        //     if (s >= 90)
        //     {
        //         Debug.Log("A");
        //     }
        //     else if (s >= 70)
        //     {
        //         Debug.Log("C");
        //     }
        //     else
        //     {
        //         Debug.Log("F");
        //     }
        // Answer: <YOUR ANSWER HERE>

        // ============================================================
        // A5: Fix the Bug (write the corrected code)
        // ============================================================
        // 17. This should print "dead" when health is 0, but it has a bug:
        //     if (health = 0)
        //     {
        //         Debug.Log("dead");
        //     }
        //
        // 18. Both calls are meant to run only when hasKey is true,
        //     but right now only the first one is:
        //     if (hasKey)
        //         Open();
        //         Enter();

        // ============================================================
        // A6: Problem Solving (write the code)
        // ============================================================
        // 19. Make ONE boolean called canOpenVault that is true only when
        //     hasKey is true AND health is greater than 0.

        // 20. Using the health above, write an if / else-if / else that prints
        //     "Dead" when health <= 0, "Low" when health < 30, otherwise "Fine".

        // 21. Apply a trap (health -= 50), then clamp health so it never goes
        //     below 0.

        // 22. LETTER GRADE: given int score (for example 75), print A, B, C, D
        //     or F using the 90 / 80 / 70 / 60 cutoffs.

        // 23. LEAP YEAR: given int year, print whether it is a leap year.
        //     A year is a leap year when it is divisible by 4, except that
        //     century years must also be divisible by 400.

        // 24. FIZZBUZZ (one number): given int n, print "Fizz" if it is
        //     divisible by 3, print "Buzz" if it is divisible by 5, print
        //     "FizzBuzz" if it is divisible by both 3 and 5, otherwise print
        //     the number itself.
    }
}
