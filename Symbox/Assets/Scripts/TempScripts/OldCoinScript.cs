using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OldCoinScript : GlobalVariables
{
    public TMP_Text displayText;
    private int moneyGiven;


    public void GrantMoney()
    {
        moneyGiven = Random.Range(minRange,maxRange);
        money += moneyGiven;
        coinText.text = "Coins: $" + money; 
    }

    public void DisplayMoneyGiven()
    {
        displayText.text = "+ " + moneyGiven + "$"; 
    }
    

    


}
