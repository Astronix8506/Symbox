using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    private int increaseMaxCost;
    private int increaseMinCost;


    void Start()
    {
        _coinScript = FindObjectOfType()
    }

    public void IncreasedMoneyMinRange()
    {
        if (money <= 5 )
        {
            minRange += 5;
            money -= 5;
            coinText.text = "Coins: $" + money; 
            Debug.Log(maxRange);
        }
    }
    public void IncreasedMoneyMaxRange()
    {
        if (money <= 5 )
        {
            maxRange += 5;
            money -= 5;
            coinText.text = "Coins: $" + money; 
            Debug.Log(minRange);
        }
    }
}
