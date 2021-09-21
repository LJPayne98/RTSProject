using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour
{
    // Start is called before the first frame update

    public Text foodText;
    private int foodAmount;

    public Text woodText;
    private int woodAmount;

    public Text oreText;
    private int oreAmount;


    void Start()
    {   
        initializeResources();
    }

    private void initializeResources()
    {
        foodAmount = Food.GetFoodAmount();
        woodAmount = Wood.GetWoodAmount();
        oreAmount = Ore.GetOreAmount();
    }
    // Update is called once per frame
    void Update()
    {   

        foodText.text = "Food: " + foodAmount;
        woodText.text = "Wood: " + woodAmount;
        oreText.text = "Ore: " + oreAmount;
    }
}
