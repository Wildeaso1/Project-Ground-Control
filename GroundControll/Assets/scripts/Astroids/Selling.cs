using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selling : MonoBehaviour
{
    public static int IronSell;
    public static int GoldSell;
    public static int CobaltSell;

    public void Start()
    {
        IronSell = 100;
        GoldSell = 300;
        CobaltSell = 200;
    }
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
