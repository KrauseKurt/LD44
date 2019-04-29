using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    [Header("Prices")]
    /// <summary>
    /// Table price hearts
    /// </summary>
    public int[] PriceHearts = new int[10];
    /// <summary>
    /// Table price hearts
    /// </summary>
    public int[] PriceUpgrade = new int[10];

    [Header("HUD")]
    public Button ButtonBuyHearts;
    public Button ButtonBuyUpgrade;

    void Awake()
    {
        // Listens buttons
        ButtonBuyHearts.onClick.AddListener(BuyHeart);
        ButtonBuyUpgrade.onClick.AddListener(BuyUpgrade);
    }

    /// <summary>
    /// Buy  one heart
    /// </summary>
    public void BuyHeart()
    {
        if (Pay(PriceHearts[GameController.Hearts]))
        {
            GameController.Life += 4;
            GameController.Hearts += 1;
            //GameController.Player.AddLife();
        }
    }

    /// <summary>
    /// Buy one upgrade
    /// </summary>
    public void BuyUpgrade()
    {
        if (Pay(PriceUpgrade[GameController.PowerDamage]))
        {
            GameController.PowerDamage += 4;
            //GameController.Player.PowerDamage();
        }
    }

    /// <summary>
    /// Payed to buy anything
    /// </summary>
    /// <returns>If can to buy</returns>
    private static bool Pay(int cust)
    {
        if (GameController.Coins > cust)
        {
            GameController.Coins -= cust;
            return true;
        }
        return false;
    }
}
