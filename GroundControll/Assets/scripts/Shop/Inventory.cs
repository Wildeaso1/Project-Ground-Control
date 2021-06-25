using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    // alle variable voor de inventory
    public static int ScoreIron;
    public static int ScoreCobalt;
    public static int ScoreGold;
    public static int ScoreCredits;
    public Text TextIron;
    public Text TextGold;
    public Text TextCobalt;
    public Text TextCredits;
    // Start score values
    void Start()
    {
        ScoreIron = 0;
        ScoreCobalt = 0;
        ScoreGold = 0;
        ScoreCredits = 0;
        ScoreCredits = PlayerPrefs.GetInt("Credits");
        ScoreIron = PlayerPrefs.GetInt("Iron");
        ScoreGold = PlayerPrefs.GetInt("Gold");
        ScoreCobalt = PlayerPrefs.GetInt("Cobalt");
    }

    // Updates the scores and text every frame
    void Update()
    {
        TextIron.text = "" + ScoreIron;
        TextGold.text = "" + ScoreGold;
        TextCobalt.text = "" + ScoreCobalt;
        TextCredits.text = "" + ScoreCredits;
        PlayerPrefs.SetInt("Credits", ScoreCredits);
        PlayerPrefs.SetInt("Iron", ScoreIron);
        PlayerPrefs.SetInt("Gold", ScoreGold);
        PlayerPrefs.SetInt("Cobalt", ScoreCobalt);
    }
}
