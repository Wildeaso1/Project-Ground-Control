using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{
    public Text ShopIron;
    public Text ShopGold;
    public Text ShopCobalt;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        ShopIron.text = "" + Inventory.ScoreIron;
        ShopGold.text = "" + Inventory.ScoreGold;
        ShopCobalt.text = "" + Inventory.ScoreCobalt;
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
