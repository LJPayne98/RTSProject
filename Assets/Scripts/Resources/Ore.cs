using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ore 
{
    private static int oreAmount;

    public static void addOreAmount(int amount)
    {
        oreAmount += amount;
    }

    public static int GetOreAmount()
    {
        return oreAmount;
    }

}