using UnityEngine;

// Variables, Data Types & Operators
// Attach this to an empty GameObject and press Play. Work through the TODOs.
public class L5_Variables_Operators_Reps : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Declare a variable of the RIGHT type (write the full line):
        // TODO   1. arrows: 12
        int arrows = 12;
        // TODO   2. player's name: Kael
        string players_name = "Kael";
        // TODO   3. gate is open: true
        bool gate_is_open = true;
        // TODO   4. a single grade letter: B
        char a_single_grade_letter = 'B';
        // TODO   5. move speed: 4.5
        float move_speed = 4.5f;
        // TODO   6. a precise price: 19.99
        double a_precise_price = 19.99;

        // TODO A2. Name the TYPE (int / float / double / char / bool / string):
        // TODO   7. number of potions: int
        // TODO   8. character name: string
        // TODO   9. is the door locked: bool
        // TODO   10. one keyboard key as a letter: char

        // TODO A3. Compute the result (write the value as a comment):
        // TODO   11. 8 + 5        13. 20 % 6        15. 2 + 3 * 4
        Debug.Log(8 + 5);
        Debug.Log(20 % 6);
        Debug.Log(2 + 3 * 4);
        // TODO   12. 15 / 4       14. 10 % 2        16. (2 + 3) * 4
        Debug.Log(15 / 4);
        Debug.Log(10 % 2);
        Debug.Log((2 + 3) * 4);

        // TODO A4. Rewrite each with a COMPOUND operator:
        // TODO   17. score = score + 100;
        // score += 100;
        // TODO   18. health = health - 20;
        // health -= 20;
        // TODO   19. speed = speed * 2;
        // speed *= 2;
        // TODO   20. lives = lives - 1;   (also show the -- form)
        // lives --x;

        // TODO A5. PREDICT the final value (write it as a comment):
        // TODO   21.   int x = 10;
        //              x += 5;
        //              x -= 3;
        Debug.Log(12);
        // TODO   22.   int h = 100;
        //              h -= 30;
        //              h += 2 * 20;
        Debug.Log(110);

        // TODO 23. Declare four stats for a MONSTER (name, health, attack,
        //          alive) with proper types, then print them on one line.
        string monster_name = "Glorp the gluttonous";
        int monster_health = 100;
        int monster_damage = 25;
        bool is_monster_alive = true;
        Debug.Log(monster_name + ", " + monster_health + ", " + monster_damage + ", " + is_monster_alive);

        // TODO 24. int health = 100; apply a 25 hit, a 40 heal, a 60 hit with
        //          compound operators, printing health after each. What three
        //          numbers appear?
        int health = 100;
        health -= 25;
        Debug.Log(health);
        health += 40;
        Debug.Log(health);
        health -= 60;
        Debug.Log(health);

        // TODO 25. Fix each broken line, then write the corrected version:
        //            int speed = 5.5;
        float speed = 5.5f;
        //            string name = Aria;
        string name = "Aria";
        //            int g = "20";
        int g = 20;

        // TODO 26. SWAP: int a = 3; int b = 8; write code that swaps them so
        //          a becomes 8 and b becomes 3. Try this first with an extra
        //          variable, then do it without any other variables.
        int a = 3;
        int b = 8;
        int c = 0;
        c = a;
        a = 0;
        a = b;
        b = 0;
        b = c;
        c = 0;
        Debug.Log(a + ", " + b);

        a = 3;
        b = 8;
        a = b;
        b = 0;
        b = 3;
        a -= 3;
        Debug.Log(a + ", " + b);


        // TODO 27. SECONDS TO CLOCK: given int totalSeconds, print hours, 
        //          minutes and seconds: e.g. if totalSeconds is set to:
        //              125, output is "2m 5s"
        //              3600, output is "1h"
        //              10000, output is "2h 46m 40s"

        int totalSeconds1 = 125;
        int totalSeconds2 = 3600;
        int totalSeconds3 = 10000;
        int seconds = 0;
        int minutes = 0;
        float minutesf = 0f;
        int hours = 0;
        float hoursf = 0f;

        minutes = totalSeconds1 / 60;
        minutesf = totalSeconds1 / 60f;
        minutesf -= minutes;
        minutesf = Mathf.Round(minutesf * 60);
        seconds = (int)minutesf;
        Debug.Log(minutes + "m " + seconds + "s");

        hours = totalSeconds2 / 3600;
        hoursf = totalSeconds2 / 3600f;
        hoursf -= hours;
        hoursf *= 60f;
        minutes = (int)hoursf;
        minutesf = hoursf;
        minutesf -= minutes;
        minutesf = Mathf.Round(minutesf * 60);
        seconds = (int)minutesf;
        Debug.Log(hours + "h " + minutes + "m " + seconds + "s");
        
        hours = totalSeconds3 / 3600;
        hoursf = totalSeconds3 / 3600f;
        hoursf -= hours;
        hoursf *= 60f;
        minutes = (int)hoursf;
        minutesf = hoursf;
        minutesf -= minutes;
        minutesf = Mathf.Round(minutesf * 60);
        seconds = (int)minutesf;
        Debug.Log(hours + "h " + minutes + "m " + seconds + "s");

        // TODO 28. EVERY THIRD HIT: a sword deals 10 damage, but every 3rd hit
        //          deals double. Using %, print the damage of hits 1 to 6.

        int hp = 100;
        int damage = 10;
        int hits = 0;


    }
}
