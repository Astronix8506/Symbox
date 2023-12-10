using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GiveCoin : MonoBehaviour
{
    public int maxMoneyGiven = 5;
    public int minMoneyGiven = 0;

    
    public void GiveMoney()
    {
        int moneyGiven = Random.Range(minMoneyGiven, maxMoneyGiven);
        Debug.Log("Money Given" + moneyGiven);
    }
}
