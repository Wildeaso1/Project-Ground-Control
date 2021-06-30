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
        BoosterLevelInt = PlayerPrefs.GetInt("BoosterLevel");
        GunLevelInt = PlayerPrefs.GetInt("GunLevel");
        RotationLevelInt = PlayerPrefs.GetInt("RotationLevel");

    }


    private void Update()
    {
        BoosterLevel.text = "Level: " + BoosterString;
        GunLevel.text = "Level: " + GunLevelString;
        Rotationlevel.text = "Level: " + RotationString;
        BoosterCostText.text = "" + BoosterCost;
        GunCostText.text = "" + GunCost;
        RotationCostText.text = "" + RotationCost;
        Debug.Log("Aanpassing" + BoosterLevelInt);


        switch (BoosterLevelInt)
        {
            case 1:
                break;
            case 2:
                BoosterString = "2";
                SpaceShip.thrustSpeed = 25f;
                BoosterCost = 1200;
                PlayerPrefs.SetInt("BoosterLevel", BoosterLevelInt);
                break;
            case 3:
                BoosterString = "3";
                SpaceShip.thrustSpeed = 27.5f;
                BoosterCost = 1400;
                PlayerPrefs.SetInt("BoosterLevel", BoosterLevelInt);
                break;
            case 4:
                BoosterCost = 0;
               SpaceShip.thrustSpeed = 30f;
                PlayerPrefs.SetInt("BoosterLevel", BoosterLevelInt);
                BoosterString  = "Max";
                break;
        }

        switch (RotationLevelInt)
        {
            case 1:
                PlayerPrefs.SetInt("RotationLevel", RotationLevelInt);
                break;
            case 2:
                RotationCost = 900;
                PlayerPrefs.SetInt("RotationLevel", RotationLevelInt);
                RotationString = "2";
                SpaceShip.rotationSpeed = 5f;
                break;
            case 3:
                RotationCost = 1050;
                PlayerPrefs.SetInt("RotationLevel", RotationLevelInt);
                RotationString = "3";
                SpaceShip.rotationSpeed = 6f;
                break;
            case 4:
                RotationCost = 0;
                RotationString = "Max";
                PlayerPrefs.SetInt("RotationLevel", RotationLevelInt);
                SpaceShip.rotationSpeed = 8f;
                break;
        }

        switch (GunLevelInt)
        {
            case 1:
                Damage.TakingDamage = 1f;
                PlayerPrefs.SetInt("GunLevel", GunLevelInt);
                break;
            case 2:
                GunCost = 2400;
                PlayerPrefs.SetInt("GunLevel", GunLevelInt);
                GunLevelString = "2";
                Damage.TakingDamage = 2f;
                break;
            case 3:
                GunCost = 2800;
                PlayerPrefs.SetInt("GunLevel", GunLevelInt);
                GunLevelString = "3";
                Damage.TakingDamage = 3f;
                break;
            case 4:
                GunCost = 3200;
                PlayerPrefs.SetInt("GunLevel", GunLevelInt);
                GunLevelString = "4";
                Damage.TakingDamage = 4f;
                break;
            case 5:
                GunCost = 0;
                GunLevelString = "Max";
                PlayerPrefs.SetInt("GunLevel", GunLevelInt);
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
