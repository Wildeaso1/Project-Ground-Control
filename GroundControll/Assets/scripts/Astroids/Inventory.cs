using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public static int ScoreIron;
    public static int ScoreCobalt;
    public static int ScoreGold;
    public static int ScoreCredits;
    public Text TextIron;
    public Text TextGold;
    public Text TextCobalt;
    public Text TextCredits;
    // Start is called before the first frame update
    void Start()
    {
        ScoreIron = 0;
        ScoreCobalt = 0;
        ScoreGold = 0;
        ScoreCredits = 0;
    }

    // Update is called once per frame
    void Update()
    {
        TextIron.text = "" + ScoreIron;
        TextGold.text = "" + ScoreGold;
        TextCobalt.text = "" + ScoreCobalt;
        TextCredits.text = "" + ScoreCredits;
    }
}
