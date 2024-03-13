using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInventory : MonoBehaviour
{
    public Text coinsText;
    private int keys = 0;
    private int coins = 0;

    public void AddKey()
    {
        keys++;
    }

    public bool HasKey()
    {
        return keys > 0;
    }

    public void AddCoins(int amount)
    {
        coins += amount;
        UpdateCoinsUI();
    }

    void UpdateCoinsUI()
    {
        coinsText.text = "Coins: " + coins.ToString();
    }
}
