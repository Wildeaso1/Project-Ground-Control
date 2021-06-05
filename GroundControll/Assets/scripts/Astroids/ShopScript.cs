using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    // Shop Variables
    public Text ShopIron;
    public Text ShopGold;
    public Text ShopCobalt;

    // Sell functions
    public static int IronAmount ()
    {
        return Selling.IronSell * Inventory.ScoreIron;
    }
    public static int GoldAmount()
    {
        return Selling.GoldSell * Inventory.ScoreGold;
    }
    public static int CobaltAmount()
    {
        return Selling.CobaltSell * Inventory.ScoreCobalt;
    }

    // Update de shop met de juiste variables
    void Update()
    {
        ShopIron.text = "" + Inventory.ScoreIron;
        ShopGold.text = "" + Inventory.ScoreGold;
        ShopCobalt.text = "" + Inventory.ScoreCobalt;
    }

    // Pauses game
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    // Unpauses game
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
