using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyingScript : MonoBehaviour
{
    public GameObject SpaceshipObject;
    public GameObject AsteroidObject;

    private SpaceShipScript SpaceShip;
    private AsteroidHealth Damage;

    public Text BoosterLevel;
    public Text GunLevel;
    public Text Rotationlevel;
    public Text BoosterCostText;
    public Text GunCostText;
    public Text RotationCostText;

    private int BoosterLevelInt = 1;
    private int GunLevelInt = 1;
    private int RotationLevelInt = 1;

    private int BoosterCost = 1000;
    private int GunCost = 2000;
    private int RotationCost = 750;

    private string BoosterString;
    private string GunLevelString;
    private string RotationString;

    private void Start()
    {
        BoosterString = BoosterLevelInt.ToString();
        GunLevelString = GunLevelInt.ToString();
        RotationString = RotationLevelInt.ToString();
        SpaceShip = SpaceshipObject.GetComponent<SpaceShipScript>();
        Damage = AsteroidObject.GetComponent<AsteroidHealth>();
    }


    private void Update()
    {
        BoosterLevel.text = "Level: " + BoosterString;
        GunLevel.text = "Level: " + GunLevelString;
        Rotationlevel.text = "Level: " + RotationString;
        BoosterCostText.text = "" + BoosterCost;
        GunCostText.text = "" + GunCost;
        RotationCostText.text = "" + RotationCost;

        switch (BoosterLevelInt)
        {
            case 1:
                break;
            case 2:
                BoosterString = "2";
                SpaceShip.thrustSpeed = 25f;
                BoosterCost = 1200;
                break;
            case 3:
                BoosterString = "3";
                SpaceShip.thrustSpeed = 27.5f;
                BoosterCost = 1400;
                break;
            case 4:
               SpaceShip.thrustSpeed = 30f;
               BoosterString  = "Max";
                break;
        }

        switch (RotationLevelInt)
        {
            case 1:
                break;
            case 2:
                RotationCost = 900;
                RotationString = "2";
                SpaceShip.rotationSpeed = 5f;
                break;
            case 3:
                RotationCost = 1050;
                RotationString = "3";
                SpaceShip.rotationSpeed = 6f;
                break;
            case 4:
                RotationString = "Max";
                SpaceShip.rotationSpeed = 8f;
                break;
        }

        switch (GunLevelInt)
        {
            case 1:
                Damage.TakingDamage = 1f;
                break;
            case 2:
                GunCost = 2400;
                GunLevelString = "2";
                Damage.TakingDamage = 2f;
                break;
            case 3:
                GunCost = 2800;
                GunLevelString = "3";
                Damage.TakingDamage = 3f;
                break;
            case 4:
                GunCost = 3200;
                GunLevelString = "4";
                Damage.TakingDamage = 4f;
                break;
            case 5:
                GunLevelString = "Max";
                Damage.TakingDamage = 5f;
                break;

        }
    }

    public void FixedUpdate()
    {
        
    }


    public void UpgradeBooster()
    {
        if (Inventory.ScoreCredits >= BoosterCost) 
        { 
            BoosterLevelInt += 1;
            Inventory.ScoreCredits -= BoosterCost;
        }
    }
    
    public void UpgradeGun()
    {
        if (Inventory.ScoreCredits >= GunCost)
        { 
            GunLevelInt += 1;
            Inventory.ScoreCredits -= GunCost;
        }
    }

    public void UpgradeRotation()
    {
        if (Inventory.ScoreCredits >= RotationCost)
        { 
            RotationLevelInt += 1;
            Inventory.ScoreCredits -= RotationCost;
        }
    }
         
}
