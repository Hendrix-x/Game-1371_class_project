using UnityEngine;

public class Coin
{
    private int value;
    public void collect()
    {
        value++;
        Debug.Log("You collected 1 Gold");
    }
    public void collect(int increase)
    {
        value += increase;
        Debug.Log("You collected " + increase + " Gold");
    }
}
