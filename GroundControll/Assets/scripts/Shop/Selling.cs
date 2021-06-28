using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Selling : MonoBehaviour
{
    //Variable voor de shop
    public Text IronSellCost;
    public Text GoldSellCost;
    public Text CobaltSellCost;

    public static int IronSell;
    public static int GoldSell;
    public static int CobaltSell;

    // Ore prijs
    public void Start()
    {
        IronSell = 20000;
        GoldSell = 100;
        CobaltSell = 40;
    }

    public void Update()
    {
        IronSellCost.text = "" + IronSell;
        GoldSellCost.text = "" + GoldSell;
        CobaltSellCost.text = "" + CobaltSell;
    }

    // Functions om de credit met het amount te verhogen
    public void SellIron()
    {
        Inventory.ScoreCredits += ShopScript.IronAmount();
        Inventory.ScoreIron = 0;
    }
    public void SellGold ()
    {
        Inventory.ScoreCredits += ShopScript.GoldAmount();
        Inventory.ScoreGold = 0;
    }
    public void SellCobalt()
    {
        Inventory.ScoreCredits += ShopScript.CobaltAmount();
        Inventory.ScoreCobalt = 0;
    }
}
