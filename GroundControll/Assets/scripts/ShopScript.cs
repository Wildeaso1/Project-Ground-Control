using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopScript : MonoBehaviour
{

    public Text TextIron;
    public Text TextGold;
    public Text TextCobalt;
    public Text TextCredits;


    public Text TextCannonLevel;
    public Text cannonUpgradeCost;
    public float cannonCost = SpaceShipScript.cannonLevel * 10;
    public Text textBoosterLevel;
    public Text boosteUpgradeCost;
    public float boosterCost = SpaceShipScript.boosterLevel * 10;
    public Text textRoationLevel;
    public Text rotationUpgradeCost;
    public float rotationCost = SpaceShipScript.rotationLevel * 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextIron.text = "" + Inventory.ScoreIron;
        TextGold.text = "" + Inventory.ScoreGold;
        TextCobalt.text = "" + Inventory.ScoreCobalt;
        TextCredits.text = "" + Inventory.ScoreCredits;

        
        if(SpaceShipScript.cannonLevel == 3) // cannon text update
        {
            cannonCost = 0;
            TextCannonLevel.text = "Max";
            cannonUpgradeCost.text = "-/-";
        }

        else if(SpaceShipScript.cannonLevel <= 3)
        {
            cannonCost = SpaceShipScript.cannonLevel * 10;
            TextCannonLevel.text = SpaceShipScript.cannonLevel.ToString();
            cannonUpgradeCost.text = cannonCost.ToString();
        }

        boosterCost = SpaceShipScript.boosterLevel * 10;
        rotationCost = SpaceShipScript.rotationLevel * 10;

        textBoosterLevel.text = SpaceShipScript.cannonLevel.ToString();
        boosteUpgradeCost.text = boosterCost.ToString();
        textRoationLevel.text = SpaceShipScript.cannonLevel.ToString();
        rotationUpgradeCost.text = rotationCost.ToString();



    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void selliron()
    {
        if (Inventory.ScoreIron >= 2)
        {
            Inventory.ScoreIron = Inventory.ScoreIron - 2;
            Inventory.ScoreCredits = Inventory.ScoreCredits + 2;
            Debug.Log("Iron: " + Inventory.ScoreIron);
            Debug.Log("Credit: " + Inventory.ScoreCredits);
        }
    }

    public void sellgold()
    {
        if (Inventory.ScoreGold >= 2)
        {
            Inventory.ScoreGold = Inventory.ScoreGold - 2;
            Inventory.ScoreCredits = Inventory.ScoreCredits + 5;
            Debug.Log("Gold: " + Inventory.ScoreGold);
            Debug.Log("Credit: " + Inventory.ScoreCredits);
        }
    }

    public void sellCobalt()
    {
        if (Inventory.ScoreCobalt >= 2)
        {
            Inventory.ScoreCobalt = Inventory.ScoreCobalt - 2;
            Inventory.ScoreCredits = Inventory.ScoreCredits + 10;
            Debug.Log("Cobalt: " + Inventory.ScoreCobalt);
            Debug.Log("Credit: " + Inventory.ScoreCredits);
        }
    }

    public void Upgrade0()
    {
        if(SpaceShipScript.rotationLevel == 3)
        {
            TextCannonLevel.text = "Max";
        }

        else if (Inventory.ScoreCredits >= rotationCost)
        {
            SpaceShipScript.rotationLevel = SpaceShipScript.rotationLevel + 1;
            Debug.Log(SpaceShipScript.rotationLevel);
        }
    }


    public void Upgrade1()
    {
        if (SpaceShipScript.boosterLevel == 5)
        {

        }

        else if (Inventory.ScoreCredits >= boosterCost)
        {
            SpaceShipScript.boosterLevel = SpaceShipScript.boosterLevel + 1;
            Debug.Log(SpaceShipScript.boosterLevel);
        }
    }

    public void Upgrade2()
    {
        if (SpaceShipScript.rotationLevel == 4)
        {

        }

        else if (Inventory.ScoreCredits >= rotationCost)
        {
            SpaceShipScript.rotationLevel = SpaceShipScript.rotationLevel + 1;
            Debug.Log(SpaceShipScript.rotationLevel);
            //Inventory.ScoreCredits = Inventory.ScoreCredits - rotationCost;
        }
    }
}

