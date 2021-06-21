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
    public int cannonCost = SpaceShipScript.cannonLevel * 10;
    public Text textBoosterLevel;
    public Text boosteUpgradeCost;
    public int boosterCost = SpaceShipScript.boosterLevel * 10;
    public Text textRoationLevel;
    public Text rotationUpgradeCost;
    public int rotationCost = SpaceShipScript.rotationLevel * 10;
    

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

        boosterCost = SpaceShipScript.boosterLevel * 10;
        rotationCost = SpaceShipScript.rotationLevel * 10;
        cannonCost = SpaceShipScript.cannonLevel * 10;

        textBoosterLevel.text = SpaceShipScript.boosterLevel.ToString();
        boosteUpgradeCost.text = boosterCost.ToString();

        textRoationLevel.text = SpaceShipScript.rotationLevel.ToString();
        rotationUpgradeCost.text = rotationCost.ToString();

        TextCannonLevel.text = SpaceShipScript.cannonLevel.ToString();
        cannonUpgradeCost.text = cannonCost.ToString();

        
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
            
        }

        else if (Inventory.ScoreCredits >= rotationCost)
        {
            SpaceShipScript.rotationLevel = SpaceShipScript.rotationLevel + 1;
            Debug.Log(SpaceShipScript.rotationLevel);
            Inventory.ScoreCredits = Inventory.ScoreCredits - rotationCost;
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
            Inventory.ScoreCredits = Inventory.ScoreCredits - boosterCost;
        }
    }

    public void Upgrade2()
    {
        if (SpaceShipScript.cannonLevel == 4)
        {

        }

        else if (Inventory.ScoreCredits >= cannonCost)
        {
            SpaceShipScript.cannonLevel = SpaceShipScript.cannonLevel + 1;
            Debug.Log(SpaceShipScript.cannonLevel);
            Inventory.ScoreCredits = Inventory.ScoreCredits - cannonCost;
        }
    }
}

