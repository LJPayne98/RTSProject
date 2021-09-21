using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood 
{
    private static int woodAmount;

    public static void addWoodAmount(int amount)
    {
        woodAmount += amount;
    }

    public static int GetWoodAmount()
    {
        return woodAmount;
    }

}