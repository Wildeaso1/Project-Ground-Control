using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selling : MonoBehaviour
{
    //Variable voor de shop
    public static int IronSell;
    public static int GoldSell;
    public static int CobaltSell;

    // Ore prijs
    public void Start()
    {
        IronSell = 100;
        GoldSell = 300;
        CobaltSell = 200;
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
