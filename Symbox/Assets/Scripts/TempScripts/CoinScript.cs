using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public TMP_Text coinText;
    private int money;
    private int maxRange = 500;
    private int minRange = 0;


    public void GrantMoney()
    {
        money += Random.Range(minRange,maxRange);
        coinText.text = "Coins: $" + money; 
    }
}
