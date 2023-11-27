using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GiveCoin : MonoBehaviour
{
    public int maxMoneyGiven = 5;

    
    public void GiveMoney()
    {
        int moneyGiven = Random.Range(0, maxMoneyGiven);
        Debug.Log("Money Given" + moneyGiven);
    }
}
