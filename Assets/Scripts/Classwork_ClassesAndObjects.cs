using System.ComponentModel.Design.Serialization;
using Unity.VisualScripting;
using UnityEngine;
// Object-Oriented Programming: Classes & Objects
// Work through the TODOs. Attach this to an empty GameObject and press Play to test.
// The generic Enemy class lives in its own file (Enemy.cs) - you will make a
// goblin and an ogre from that same class. Three shape classes are stubbed at
// the BOTTOM of this file for the last section. (Add any class you WRITE
// yourself at the bottom of this file too, outside this class.)
public class Classwork_ClassesAndObjects : MonoBehaviour
{
    void Start()
    {
        // TODO A1. Data or behavior? (is this a member variable or a method?)
        // TODO     1. int health = 30;
        // Answer:  <variable>
        // TODO     2. void Attack()
        // Answer:  <method>
        // TODO     3. string name;
        // Answer:  <variable>
        // TODO     4. bool IsAlive()
        // Answer:  <method>

        // TODO A2. Class or object? (the blueprint, or one instance?)
        // TODO     5. class Enemy { ... }
        // Answer:  <Class>
        // TODO     6. Enemy e = new Enemy();
        // Answer:  <object>
        // TODO     7. the cookie cutter
        // Answer:  <Class>
        // TODO     8. one baked cookie
        // Answer:  <object>

        // TODO A3. public or private? (which should it be?)
        // TODO     9. a health value only the object should change
        // Answer:  <private>
        // TODO     10. a method other scripts must call
        // Answer:  <public>

        // TODO A4. Fill in the blank (answer in a comment):
        // TODO     11. A class bundles ______ (member variables) and ______ (methods).
        // Answer:  <Data, behaviors>
        // TODO     12. You make an object from a class with the ______ keyword.
        // Answer:  <new>
        // TODO     13. ": MonoBehaviour" means your class is a Unity ______.
        // Answer:  <YOUR ANSWER HERE>

        // TODO     14. Using the Enemy class (in Enemy.cs), create TWO enemies
        //              from that same class: a goblin and an ogre. Give the
        //              goblin the name "Goblin" and the ogre the name "Ogre",
        //              and set each one's health and attack (make the ogre the
        //              tougher of the two).
        Enemy Goblin = new Enemy()
        {
            name = "goblin",
            health = 20,
            attack = 15
        };

        Enemy Ogre = new Enemy()
        {
            name = "ogre",
            health = 40,
            attack = 25
        };

        // TODO     15. Call Describe() on both enemies to print their stats.
        Goblin.Describe();
        Ogre.Describe();

        // TODO     16. Deal enough damage to DEFEAT the goblin but not the ogre,
        //              then print IsAlive() for each. They came from the same
        //              class, but show they hold SEPARATE health.
        Goblin.TakeDamage(20);
        Ogre.TakeDamage(20);
        Debug.Log(Goblin.IsAlive());
        Debug.Log(Ogre.IsAlive());

        // TODO     17. WRITE A CLASS: create a class Coin with a public int
        //              value and a public method Collect() that prints
        //              "Collected " + value + " gold." Then make one and
        //              collect it (add your class at the bottom of this file).

        Coin Gold = new Coin();
        Gold.collect();

        // TODO     18. WHY PRIVATE? In the in-class example the Player's health
        //              was private while its gold was public. In a comment,
        //              explain why hiding health behind a TakeDamage method can
        //              be safer than leaving health as a public member variable.
        // Answer:  <Private variables are kept exclusively to the object and can't be used elsewhere. Keeping variables private means that you
        // can only use specific actions on the variable, those which are considered safe to do.>

        // TODO     19. CLASS vs OBJECT: in one sentence, explain the difference
        //              using the goblin and ogre you made from the Enemy class.
        // Answer:  <A class is a container for all the information and actions that the eventual object will use.
        // An object is an instance of a class with the instructions executed.>

        // ===================== SHAPES =====================
        // Three empty shape classes are stubbed at the BOTTOM of this file. Fill
        // each one in (the member variables that define it, and its methods),
        // then make one of each here and print what it tells you.

        // TODO     20. CIRCLE: in the Circle class (below), add a radius, an
        //              Area() method, and a Circumference() method. Then make a
        //              Circle here, give it a radius, and print its area and its
        //              circumference.

        Circle CircleClass = new Circle();
        Debug.Log("Area: " + CircleClass.area());
        Debug.Log("Circumfrence: " + CircleClass.circumfrence());

        // TODO     21. RECTANGLE: in the Rectangle class (below), add a width and
        //              a height, an Area() method, and a Perimeter() method. Then
        //              make a Rectangle here, give it a width and height, and
        //              print its area and its perimeter.

        Rectangle RectClass = new Rectangle();
        Debug.Log("Area: " + RectClass.area());
        Debug.Log("Perimeter: " + RectClass.perimeter());

        // TODO     22. TRIANGLE: in the Triangle class (below), add member
        //              variables for its three sides, plus a base and a height.
        //              (base is a reserved word in C#, so name it something like
        //              baseLength.) Add an Area() method (from the base and
        //              height), a Perimeter() method (from the three sides), and
        //              a method that returns whether the three sides form a VALID
        //              triangle. Then make a Triangle here, fill in its values,
        //              and print its area, its perimeter, and whether it is valid.
        Triangle TriClass = new Triangle();
        Debug.Log("Area: " + TriClass.area());
        Debug.Log("Perimeter: " + TriClass.perimeter());
        Debug.Log("Is valid triangle?: " + TriClass.isCorrect());
    }
}

// The Enemy class lives in its own file, Enemy.cs (tasks 14-16 use it).

// TODO: add your Coin class in a new file (task 17).

// ---------- SHAPE CLASSES TO FILL IN (tasks 20-22) ----------
// (in a real project each of these would live in its own file)



public class Circle
{
    private int radius = 12;
    public int area()
    {
        return radius * 2;
    }
    public double circumfrence()
    {
        return 2 *(3.14) * area();
    }
}

public class Rectangle
{
    private int length = 7;
    private int height = 9;
    public int area()
    {
        return height * length;
    }
    public int perimeter()
    {
        return 2 * (height * length);
    }
}

public class Triangle
{
    private int side1 = 12;
    private int side2 = 16;
    private int side3 = 13;
    private int baseLength = 12;
    private int height = 14;
    public int area()
    {
        return baseLength * height;
    }
    public int perimeter()
    {
        return side1 + side2 + side3;
    }
    public bool isCorrect()
    {
        return side1 + side2 > side3;
    }
}
