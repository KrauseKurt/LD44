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
        if (Pay(PriceHearts[GameController.Instance.Hearts]))
        {
            GameController.Instance.Life += 4;
            GameController.Instance.Hearts += 1;
            //GameController.Player.AddLife();
            GameController.Instance.Hud.HeartsManager();
        }
    }

    /// <summary>
    /// Buy one upgrade
    /// </summary>
    public void BuyUpgrade()
    {
        if (Pay(PriceUpgrade[GameController.Instance.PowerDamage]))
        {
            GameController.Instance.PowerDamage += 4;
            //GameController.Player.PowerDamage();
        }
    }

    /// <summary>
    /// Payed to buy anything
    /// </summary>
    /// <returns>If can to buy</returns>
    private static bool Pay(int cust)
    {
        if (GameController.Instance.Coins > cust)
        {
            GameController.Instance.Coins -= cust;
            return true;
        }
        return false;
    }
}
