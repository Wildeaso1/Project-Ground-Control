using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyHealth : MonoBehaviour
{

    public static int cost = 200;
    public bool heal = false;
    

    private void Update()
    {
        if (heal == true)
        {
            Sell();
            heal = false;
        }
        

    }

    public void Sell()
    {

        if (Inventory.ScoreCredits >= cost)
		{
            Inventory.ScoreCredits -= cost;
            PlayerHP.PlayerHealth = PlayerHP.MaxHealth;
            PlayerPrefs.SetInt("PlayerHP", PlayerHP.MaxHealth);
            
        }
        

        

        heal = true;
    }
}
