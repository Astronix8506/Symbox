using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GlobalVariables : MonoBehaviour
{
    public static int coinCount;
    public TMP_Text coinDisplay;
    public int internalCoin;

    void update ()
    {
        internalCoin = coinCount;
        coinDisplay.text = "Coins: " + internalCoin.ToString();
    }
}
