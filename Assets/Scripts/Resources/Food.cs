using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food 
{
    private static int foodAmount;

    public static void addFoodAmount(int amount)
    {
        foodAmount += amount;
    }

    public static int GetFoodAmount()
    {
        return foodAmount;
    }

}
