using UnityEngine;
// Name: 
// Assignment: Intro to C# and Unity
// Instructions: Work through the TODOs. Attach this to an empty GameObject
//      and press Play to test and verify.

public class Classwork_IntroToCSharpAndUnity_HEDEKER : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Write the Debug.Log that prints EXACTLY the following
        //          (one debug statement per number)
        // TODO     1. Hello, dungeon!
        // TODO     2. A rat scurries past.
        // TODO     3. Game Over
        // TODO     4. ------------------
        Debug.Log("Hello, dungeon!");
        Debug.Log("A rat scurries past.");
        Debug.Log("Game Over");
        Debug.Log("------------------");

        // TODO A2. PREDICT the output word-for-word (write your prediction
        //          as a comment. Test the code to see if you are correct.):
        // TODO     5. Debug.Log("Gold: 20");
        // TODO     6. int gold = 20;
        //             Debug.Log("Gold: " + gold);
        // TODO     7. int a = 3;
        //             Debug.Log("a is a");
        // TODO     8. int a = 3;
        //             Debug.Log("a is " + a);
        // TODO     9. Debug.Log("2 + 2 = " + (2 + 2));
        Debug.Log("Gold: 20");
        Debug.Log("a is 3");
        Debug.Log("2 + 2 = 4");

        // TODO A3. FIX the mistake in each line, then write the corrected line:
        // TODO     10. Debug.Log(Hello);
        // TODO     11. Debug.log("hi");
        // TODO     12. Debug.Log("You have " gold);
        // TODO     13. Debug.Log("Torches: " + 3
        // TODO     14. debug.Log("test");

        //Debug.Log("Hello");
        //Debug.Log("hi");
        //Debug.Log("You have " + gold);
        //Debug.Log("Torches: " + 3);
        //Debug.Log("test");

        // TODO A4. TRUE or FALSE (answer in a comment):
        // TODO     15. A script in Player.cs must contain  class Player.
        // Answer:  <TRUE>
        // TODO     16. Debug.Log prints to the Game view.
        // Answer:  <FALSE>
        // TODO     17. Start() runs once when you press Play.
        // Answer:  <TRUE>

        // TODO     18. Given  int hp = 100;  print:  Health: 100
        int hp = 100;
        Debug.Log("Health: " + hp);

        // TODO 19. Given  string room = "Vault";  print:  You enter the Vault
        string room = "Vault";
        Debug.Log("You enter the " + room);

        // TODO 20. Given  int gold = 35, keys = 2;  print:  35 gold and 2 keys
        int gold = 35;
        int keys = 2;
        Debug.Log(gold + " gold and " + keys + " keys");

        // TODO 21. Write code that prints a 3-line room: a title, a
        //          description, and an exits line.
        Debug.Log("Kitchen");
        Debug.Log("The kitchen is dirty and overrun with uncleaned dishes stacked tall enough to nearly touch the floor.");
        Debug.Log("You leave the kitchen. We can come back for a snack later.");

        // TODO 22. LABEL AND VALUE: given int score = 7 and int lives = 3,
        //          print ONE line:  Score 7 (3 lives left)   using + only.
        int score = 7;
        int lives = 3;

        Debug.Log("Score " + score + " (" + lives + " lives left)");
    }
}
