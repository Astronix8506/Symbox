using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    private int money = 0;
    private int currentMoney = 0;

    public int AddCoin(int deposit)
    {
        currentMoney += deposit;
        return currentMoney;
    }

    public int SubtractCoin(int withdraw)
    {
        currentMoney -= withdraw;
        return money;
    }
    
}
